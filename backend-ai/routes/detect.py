
from flask import Blueprint, request, jsonify

detect_bp = Blueprint('detect', __name__)

@detect_bp.route('/detect', methods=['POST'])
def detect():
    # Mock detection result
    result = {
        "detections": [
            {
                "label": "gear_shift",
                "confidence": 0.91,
                "bbox": [120, 220, 180, 300]
            },
            {
                "label": "ac_control",
                "confidence": 0.88,
                "bbox": [300, 180, 360, 240]
            }
        ]
    }
    return jsonify(result)
