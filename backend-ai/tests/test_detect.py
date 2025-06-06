import io
import os
import sys
import types
from PIL import Image
import pytest

# Stub ultralytics.YOLO to avoid heavy dependency during tests
if 'ultralytics' not in sys.modules:
    ultralytics = types.ModuleType('ultralytics')
    class YOLO:
        def __init__(self, *args, **kwargs):
            pass
        def predict(self, image):
            return []
    ultralytics.YOLO = YOLO
    sys.modules['ultralytics'] = ultralytics
sys.path.insert(0, os.path.abspath(os.path.join(os.path.dirname(__file__), "..")))

from app import app

@pytest.fixture
def client():
    app.config['TESTING'] = True
    with app.test_client() as client:
        yield client


def test_detect(monkeypatch, client):
    def fake_predict(image):
        class XY(list):
            def tolist(self):
                return list(self)
        class Box:
            def __init__(self):
                self.cls = 0
                self.xyxy = [XY([0, 0, 1, 1])]
                self.conf = 0.9
        class Result:
            boxes = [Box()]
            names = {0: 'object'}
        return [Result()]

    monkeypatch.setattr('routes.detect.model.predict', fake_predict)

    img_bytes = io.BytesIO()
    Image.new('RGB', (1, 1)).save(img_bytes, format='JPEG')
    img_bytes.seek(0)
    data = {'image': (img_bytes, 'test.jpg')}

    response = client.post('/detect', data=data, content_type='multipart/form-data')
    assert response.status_code == 200
    assert isinstance(response.get_json(), list)
