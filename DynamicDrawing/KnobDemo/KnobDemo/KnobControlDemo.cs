using System;
using Foundation;
using UIKit;
using CoreGraphics;

namespace KnobDemo
{
    [Register("KnobControlDemo")]
    public class KnobControlDemo : UIView
    {
        private UILabel _valueLabel;
        ArtboardKnobDrawing _artboardKnobDrawing;

        private nfloat _currentValue;
        public nfloat CurrentValue
        {
            get { return _currentValue; }
            set { _currentValue = value; }
        }

        private nfloat _rotationAngle;
        public nfloat RotationAngle
        {
            get
            {
                return _rotationAngle;
            }
            set
            {
                _rotationAngle = value;
                _valueLabel.Text = Convert.ToInt32(_rotationAngle).ToString();
                this.SetNeedsDisplay();
            }
        }

        private void Initialize()
        {
            _valueLabel = new UILabel()
            {
                Frame = Bounds,
                Font = UIFont.SystemFontOfSize(22.0F),
                TextColor = UIColor.Gray,
                Text = _currentValue.ToString(),
                TextAlignment = UITextAlignment.Center
            };

            AddSubview(_valueLabel);
            _artboardKnobDrawing = new ArtboardKnobDrawing();
        }

        public KnobControlDemo(IntPtr handle) : base(handle)
        {
            Initialize();
        }

        public override void Draw(CGRect rect)
        {
            base.Draw(rect);
            _artboardKnobDrawing.RotationAngleDegree = RotationAngle;
            _artboardKnobDrawing.RotationAngleRadian = RotationAngle * ((nfloat)Math.PI) / 180.0f;
            _artboardKnobDrawing.DrawArtboardKnobDrawing(rect, ArtboardKnobDrawing.ArtboardKnobDrawingFillMode.ArtboardKnobDrawingFit);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            _valueLabel = null;
            _artboardKnobDrawing = null;
        }
    }
}
