
from flask import Flask
from routes.detect import detect_bp

app = Flask(__name__)
app.register_blueprint(detect_bp)

if __name__ == "__main__":
    app.run(host="0.0.0.0", port=5000)
