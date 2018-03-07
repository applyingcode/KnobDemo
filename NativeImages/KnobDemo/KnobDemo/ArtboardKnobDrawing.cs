// +----------------------------------------------------+
// | Petra Plugin For Sketch                            |
// | Copyright(c) 2016 www.applyingcode.com             |
// +----------------------------------------------------+
// | Xamarin C# code for iOS                            |
// +----------------------------------------------------+
//   3/4/18 8:29:18 PM

using System;
using Foundation;
using UIKit;
using CoreGraphics;

namespace KnobDemo
{
    [Register("ArtboardKnobDrawing")]
    public class ArtboardKnobDrawing : NSObject
    {
        public bool DrawParentImage;

        public enum ArtboardKnobDrawingFillMode
        {
            ArtboardKnobDrawingFit,
            ArtboardKnobDrawingFill,
            ArtboardKnobDrawingStretch,
            ArtboardKnobDrawingOriginal
        };

        ArtboardKnobDrawingFillMode artboardKnobDrawingFillMode;
        double artboardKnobDrawingHeight;
        double artboardKnobDrawingWidth;
        CGRect newArtboardSize;
        CGSize resizedScale;
        CGAffineTransform baseTransform;

        // Initialize defaults
        public ArtboardKnobDrawing()
        {
            artboardKnobDrawingWidth = 230.000000;
            artboardKnobDrawingHeight = 230.000000;
            artboardKnobDrawingFillMode = ArtboardKnobDrawingFillMode.ArtboardKnobDrawingFit;
            DrawParentImage = false;
        }

        //
        // ArtboardKnobDrawing
        //
        public void DrawArtboardKnobDrawing(CGRect bounds, ArtboardKnobDrawingFillMode fillMode)
        {
            CGContext context;

            // Get CGContext instance
            context = UIGraphics.GetCurrentContext();

            // Affine Transform
            baseTransform = CoreGraphics.CGAffineTransform.CGAffineTransformInvert(context.GetUserSpaceToDeviceSpaceTransform());

            // Save initial context state
            context.SaveState();

            // Initialize and set new artboard size (scaled)
            newArtboardSize = GetNewArtboardSize(fillMode, new CGRect(0.0, 0.0, 230.000000, 230.000000), new CGRect(bounds.Left, bounds.Top, bounds.Width, bounds.Height));
            context.TranslateCTM(newArtboardSize.X, newArtboardSize.Y);
            resizedScale = new CGSize(newArtboardSize.Width / 230.000000, newArtboardSize.Height / 230.000000);
            context.ScaleCTM(resizedScale.Width, resizedScale.Height);

            // Drawing procedures

            if(DrawParentImage)
                DrawShapeObjectRectangleBackground(context);
            DrawGroupObjectKnob(context);

            // Restore initial context state
            context.RestoreState();

        }

        //
        // ShapeObjectRectangleBackground
        //
        private void DrawShapeObjectRectangleBackground(CGContext context)
        {
            UIBezierPath ShapeObjectRectangleBackground;

            // Shape Path
            ShapeObjectRectangleBackground = new UIBezierPath();
            ShapeObjectRectangleBackground.MoveTo(new CGPoint(16.665254, -0.000000));
            ShapeObjectRectangleBackground.AddLineTo(new CGPoint(213.334746, 0.000000));
            ShapeObjectRectangleBackground.AddCurveToPoint(new CGPoint(223.349497, 1.736363), new CGPoint(219.129618, -0.000000), new CGPoint(221.230979, 0.603366));
            ShapeObjectRectangleBackground.AddCurveToPoint(new CGPoint(228.263637, 6.650503), new CGPoint(225.468016, 2.869359), new CGPoint(227.130641, 4.531984));
            ShapeObjectRectangleBackground.AddCurveToPoint(new CGPoint(230.000000, 16.665254), new CGPoint(229.396634, 8.769021), new CGPoint(230.000000, 10.870382));
            ShapeObjectRectangleBackground.AddLineTo(new CGPoint(230.000000, 213.334746));
            ShapeObjectRectangleBackground.AddCurveToPoint(new CGPoint(228.263637, 223.349497), new CGPoint(230.000000, 219.129618), new CGPoint(229.396634, 221.230979));
            ShapeObjectRectangleBackground.AddCurveToPoint(new CGPoint(223.349497, 228.263637), new CGPoint(227.130641, 225.468016), new CGPoint(225.468016, 227.130641));
            ShapeObjectRectangleBackground.AddCurveToPoint(new CGPoint(213.334746, 230.000000), new CGPoint(221.230979, 229.396634), new CGPoint(219.129618, 230.000000));
            ShapeObjectRectangleBackground.AddLineTo(new CGPoint(16.665254, 230.000000));
            ShapeObjectRectangleBackground.AddCurveToPoint(new CGPoint(6.650503, 228.263637), new CGPoint(10.870382, 230.000000), new CGPoint(8.769021, 229.396634));
            ShapeObjectRectangleBackground.AddCurveToPoint(new CGPoint(1.736363, 223.349497), new CGPoint(4.531984, 227.130641), new CGPoint(2.869359, 225.468016));
            ShapeObjectRectangleBackground.AddCurveToPoint(new CGPoint(-0.000000, 213.334746), new CGPoint(0.603366, 221.230979), new CGPoint(0.000000, 219.129618));
            ShapeObjectRectangleBackground.AddLineTo(new CGPoint(0.000000, 16.665254));
            ShapeObjectRectangleBackground.AddCurveToPoint(new CGPoint(1.736363, 6.650503), new CGPoint(-0.000000, 10.870382), new CGPoint(0.603366, 8.769021));
            ShapeObjectRectangleBackground.AddCurveToPoint(new CGPoint(6.650503, 1.736363), new CGPoint(2.869359, 4.531984), new CGPoint(4.531984, 2.869359));
            ShapeObjectRectangleBackground.AddCurveToPoint(new CGPoint(16.665254, -0.000000), new CGPoint(8.769021, 0.603366), new CGPoint(10.870382, 0.000000));
            ShapeObjectRectangleBackground.ClosePath();
            ShapeObjectRectangleBackground.MoveTo(new CGPoint(16.665254, -0.000000));

            context.SaveState();
            context.TranslateCTM(0.000000f, 0.000000f);

            // Shape Fill
            ShapeObjectRectangleBackground.UsesEvenOddFillRule = true;
            context.SaveState();
            ShapeObjectRectangleBackground.AddClip();
            FillLinearGradient(context,
              new CGPoint(86.614990f, 44.872238f),
              new CGPoint(104.888835f, 188.217693f),
              new nfloat[] { 0.000000f, 1.000000f },
              new CGColor[] {
                UIColor.FromHSBA(0.120329f, 0.057134f, 0.300409f, 1.000000f).CGColor,
                UIColor.FromHSBA(0.128935f, 0.143249f, 0.174798f, 1.000000f).CGColor
              });
            context.RestoreState();

            context.SaveState();
            context.SetBlendMode(CGBlendMode.Color);
            context.BeginTransparencyLayer(ShapeObjectRectangleBackground.Bounds, null);
            UIColor.FromHSBA(0.610337f, 0.465554f, 0.083998f, 0.500000f).SetFill();
            ShapeObjectRectangleBackground.Fill();
            context.EndTransparencyLayer();
            context.RestoreState();

            // Shape Inner Shadow
            context.SaveState();
            UIGraphics.RectClip(ShapeObjectRectangleBackground.Bounds);
            context.SetShadow(new CGSize(0, 0), 0, null);
            context.SetAlpha(0.742499f);
            context.BeginTransparencyLayer(ShapeObjectRectangleBackground.Bounds, null);
            UIColor.FromHSBA(0.000000f, 0.000000f, 0.000000f, 1.0f).SetFill();
            ShapeObjectRectangleBackground.Fill();
            context.SetBlendMode(CGBlendMode.DestinationOut);
            context.BeginTransparencyLayer(ShapeObjectRectangleBackground.Bounds, null);
            context.TranslateCTM(-230f, 0f);
            GenerateShapeInnerShadow(context, 230f, -1f, 230f);
            UIColor.Black.SetFill();
            ShapeObjectRectangleBackground.Fill();
            context.EndTransparencyLayer();
            context.EndTransparencyLayer();
            context.RestoreState();

            context.SaveState();
            UIGraphics.RectClip(ShapeObjectRectangleBackground.Bounds);
            context.SetShadow(new CGSize(0, 0), 0, null);
            context.SetAlpha(0.272390f);
            context.BeginTransparencyLayer(ShapeObjectRectangleBackground.Bounds, null);
            UIColor.FromHSBA(0.000000f, 0.000000f, 1.000000f, 1.0f).SetFill();
            ShapeObjectRectangleBackground.Fill();
            context.SetBlendMode(CGBlendMode.DestinationOut);
            context.BeginTransparencyLayer(ShapeObjectRectangleBackground.Bounds, null);
            context.TranslateCTM(-230f, 0f);
            GenerateShapeInnerShadow(context, 230f, 1f, 230f);
            UIColor.Black.SetFill();
            ShapeObjectRectangleBackground.Fill();
            context.EndTransparencyLayer();
            context.EndTransparencyLayer();
            context.RestoreState();

            context.RestoreState();

        }

        //
        // GroupObjectKnob
        //
        private void DrawGroupObjectKnob(CGContext context)
        {
            context.SaveState();

            context.TranslateCTM(23.000000f, 23.000000f);

            if (DrawParentImage)
            {
                DrawShapeObjectMarks(context);
                DrawShapeObjectFillOval(context);
                DrawShapeObjectBackOval(context);
            }
            else
            {
                DrawGroupObjectKnobGroup(context);
            }

            // ~ End GroupObjectKnob
            context.RestoreState();

        }

        //
        // ShapeObjectMarks
        //
        private void DrawShapeObjectMarks(CGContext context)
        {
            UIBezierPath ShapeObjectMarks;

            // Shape Path
            ShapeObjectMarks = new UIBezierPath();
            ShapeObjectMarks.MoveTo(new CGPoint(91.500000, 0.000000));
            ShapeObjectMarks.AddLineTo(new CGPoint(92.500000, 0.000000));
            ShapeObjectMarks.AddLineTo(new CGPoint(92.500000, 20.000000));
            ShapeObjectMarks.AddLineTo(new CGPoint(91.500000, 20.000000));
            ShapeObjectMarks.AddLineTo(new CGPoint(91.500000, 0.000000));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(91.500000, 0.000000));
            ShapeObjectMarks.MoveTo(new CGPoint(99.865016, 12.385984));
            ShapeObjectMarks.AddLineTo(new CGPoint(100.859538, 12.490513));
            ShapeObjectMarks.AddLineTo(new CGPoint(100.023310, 20.446688));
            ShapeObjectMarks.AddLineTo(new CGPoint(99.028788, 20.342159));
            ShapeObjectMarks.AddLineTo(new CGPoint(99.865016, 12.385984));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(99.865016, 12.385984));
            ShapeObjectMarks.MoveTo(new CGPoint(108.143861, 13.644236));
            ShapeObjectMarks.AddLineTo(new CGPoint(109.122009, 13.852148));
            ShapeObjectMarks.AddLineTo(new CGPoint(107.458716, 21.677329));
            ShapeObjectMarks.AddLineTo(new CGPoint(106.480568, 21.469417));
            ShapeObjectMarks.AddLineTo(new CGPoint(108.143861, 13.644236));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(108.143861, 13.644236));
            ShapeObjectMarks.MoveTo(new CGPoint(116.245831, 15.760970));
            ShapeObjectMarks.AddLineTo(new CGPoint(117.196888, 16.069987));
            ShapeObjectMarks.AddLineTo(new CGPoint(114.724752, 23.678439));
            ShapeObjectMarks.AddLineTo(new CGPoint(113.773695, 23.369422));
            ShapeObjectMarks.AddLineTo(new CGPoint(116.245831, 15.760970));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(116.245831, 15.760970));
            ShapeObjectMarks.MoveTo(new CGPoint(124.082159, 18.712995));
            ShapeObjectMarks.AddLineTo(new CGPoint(124.995704, 19.119732));
            ShapeObjectMarks.AddLineTo(new CGPoint(121.741811, 26.428095));
            ShapeObjectMarks.AddLineTo(new CGPoint(120.828266, 26.021359));
            ShapeObjectMarks.AddLineTo(new CGPoint(124.082159, 18.712995));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(124.082159, 18.712995));
            ShapeObjectMarks.MoveTo(new CGPoint(137.566987, 12.271815));
            ShapeObjectMarks.AddLineTo(new CGPoint(138.433013, 12.771815));
            ShapeObjectMarks.AddLineTo(new CGPoint(128.433013, 30.092323));
            ShapeObjectMarks.AddLineTo(new CGPoint(127.566987, 29.592323));
            ShapeObjectMarks.AddLineTo(new CGPoint(137.566987, 12.271815));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(137.566987, 12.271815));
            ShapeObjectMarks.MoveTo(new CGPoint(138.618312, 26.984748));
            ShapeObjectMarks.AddLineTo(new CGPoint(139.427329, 27.572533));
            ShapeObjectMarks.AddLineTo(new CGPoint(134.725047, 34.044669));
            ShapeObjectMarks.AddLineTo(new CGPoint(133.916030, 33.456884));
            ShapeObjectMarks.AddLineTo(new CGPoint(138.618312, 26.984748));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(138.618312, 26.984748));
            ShapeObjectMarks.MoveTo(new CGPoint(145.158876, 32.213849));
            ShapeObjectMarks.AddLineTo(new CGPoint(145.902021, 32.882979));
            ShapeObjectMarks.AddLineTo(new CGPoint(140.548976, 38.828138));
            ShapeObjectMarks.AddLineTo(new CGPoint(139.805831, 38.159007));
            ShapeObjectMarks.AddLineTo(new CGPoint(145.158876, 32.213849));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(145.158876, 32.213849));
            ShapeObjectMarks.MoveTo(new CGPoint(151.117021, 38.097979));
            ShapeObjectMarks.AddLineTo(new CGPoint(151.786151, 38.841124));
            ShapeObjectMarks.AddLineTo(new CGPoint(145.840993, 44.194169));
            ShapeObjectMarks.AddLineTo(new CGPoint(145.171862, 43.451024));
            ShapeObjectMarks.AddLineTo(new CGPoint(151.117021, 38.097979));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(151.117021, 38.097979));
            ShapeObjectMarks.MoveTo(new CGPoint(156.427467, 44.572671));
            ShapeObjectMarks.AddLineTo(new CGPoint(157.015252, 45.381688));
            ShapeObjectMarks.AddLineTo(new CGPoint(150.543116, 50.083970));
            ShapeObjectMarks.AddLineTo(new CGPoint(149.955331, 49.274953));
            ShapeObjectMarks.AddLineTo(new CGPoint(156.427467, 44.572671));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(156.427467, 44.572671));
            ShapeObjectMarks.MoveTo(new CGPoint(171.228185, 45.566987));
            ShapeObjectMarks.AddLineTo(new CGPoint(171.728185, 46.433013));
            ShapeObjectMarks.AddLineTo(new CGPoint(154.407677, 56.433013));
            ShapeObjectMarks.AddLineTo(new CGPoint(153.907677, 55.566987));
            ShapeObjectMarks.AddLineTo(new CGPoint(171.228185, 45.566987));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(171.228185, 45.566987));
            ShapeObjectMarks.MoveTo(new CGPoint(164.880268, 59.004296));
            ShapeObjectMarks.AddLineTo(new CGPoint(165.287005, 59.917841));
            ShapeObjectMarks.AddLineTo(new CGPoint(157.978641, 63.171734));
            ShapeObjectMarks.AddLineTo(new CGPoint(157.571905, 62.258189));
            ShapeObjectMarks.AddLineTo(new CGPoint(164.880268, 59.004296));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(164.880268, 59.004296));
            ShapeObjectMarks.MoveTo(new CGPoint(167.930013, 66.803112));
            ShapeObjectMarks.AddLineTo(new CGPoint(168.239030, 67.754169));
            ShapeObjectMarks.AddLineTo(new CGPoint(160.630578, 70.226305));
            ShapeObjectMarks.AddLineTo(new CGPoint(160.321561, 69.275248));
            ShapeObjectMarks.AddLineTo(new CGPoint(167.930013, 66.803112));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(167.930013, 66.803112));
            ShapeObjectMarks.MoveTo(new CGPoint(170.147852, 74.877991));
            ShapeObjectMarks.AddLineTo(new CGPoint(170.355764, 75.856139));
            ShapeObjectMarks.AddLineTo(new CGPoint(162.530583, 77.519432));
            ShapeObjectMarks.AddLineTo(new CGPoint(162.322671, 76.541284));
            ShapeObjectMarks.AddLineTo(new CGPoint(170.147852, 74.877991));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(170.147852, 74.877991));
            ShapeObjectMarks.MoveTo(new CGPoint(171.509487, 83.140462));
            ShapeObjectMarks.AddLineTo(new CGPoint(171.614016, 84.134984));
            ShapeObjectMarks.AddLineTo(new CGPoint(163.657841, 84.971212));
            ShapeObjectMarks.AddLineTo(new CGPoint(163.553312, 83.976690));
            ShapeObjectMarks.AddLineTo(new CGPoint(171.509487, 83.140462));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(171.509487, 83.140462));
            ShapeObjectMarks.MoveTo(new CGPoint(184.000000, 91.500000));
            ShapeObjectMarks.AddLineTo(new CGPoint(184.000000, 92.500000));
            ShapeObjectMarks.AddLineTo(new CGPoint(164.000000, 92.500000));
            ShapeObjectMarks.AddLineTo(new CGPoint(164.000000, 91.500000));
            ShapeObjectMarks.AddLineTo(new CGPoint(184.000000, 91.500000));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(184.000000, 91.500000));
            ShapeObjectMarks.MoveTo(new CGPoint(171.614016, 99.865016));
            ShapeObjectMarks.AddLineTo(new CGPoint(171.509487, 100.859538));
            ShapeObjectMarks.AddLineTo(new CGPoint(163.553312, 100.023310));
            ShapeObjectMarks.AddLineTo(new CGPoint(163.657841, 99.028788));
            ShapeObjectMarks.AddLineTo(new CGPoint(171.614016, 99.865016));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(171.614016, 99.865016));
            ShapeObjectMarks.MoveTo(new CGPoint(170.355764, 108.143861));
            ShapeObjectMarks.AddLineTo(new CGPoint(170.147852, 109.122009));
            ShapeObjectMarks.AddLineTo(new CGPoint(162.322671, 107.458716));
            ShapeObjectMarks.AddLineTo(new CGPoint(162.530583, 106.480568));
            ShapeObjectMarks.AddLineTo(new CGPoint(170.355764, 108.143861));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(170.355764, 108.143861));
            ShapeObjectMarks.MoveTo(new CGPoint(168.239030, 116.245831));
            ShapeObjectMarks.AddLineTo(new CGPoint(167.930013, 117.196888));
            ShapeObjectMarks.AddLineTo(new CGPoint(160.321561, 114.724752));
            ShapeObjectMarks.AddLineTo(new CGPoint(160.630578, 113.773695));
            ShapeObjectMarks.AddLineTo(new CGPoint(168.239030, 116.245831));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(168.239030, 116.245831));
            ShapeObjectMarks.MoveTo(new CGPoint(165.287005, 124.082159));
            ShapeObjectMarks.AddLineTo(new CGPoint(164.880268, 124.995704));
            ShapeObjectMarks.AddLineTo(new CGPoint(157.571905, 121.741811));
            ShapeObjectMarks.AddLineTo(new CGPoint(157.978641, 120.828266));
            ShapeObjectMarks.AddLineTo(new CGPoint(165.287005, 124.082159));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(165.287005, 124.082159));
            ShapeObjectMarks.MoveTo(new CGPoint(172.728185, 137.566987));
            ShapeObjectMarks.AddLineTo(new CGPoint(172.228185, 138.433013));
            ShapeObjectMarks.AddLineTo(new CGPoint(154.907677, 128.433013));
            ShapeObjectMarks.AddLineTo(new CGPoint(155.407677, 127.566987));
            ShapeObjectMarks.AddLineTo(new CGPoint(172.728185, 137.566987));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(172.728185, 137.566987));
            ShapeObjectMarks.MoveTo(new CGPoint(157.015252, 138.618312));
            ShapeObjectMarks.AddLineTo(new CGPoint(156.427467, 139.427329));
            ShapeObjectMarks.AddLineTo(new CGPoint(149.955331, 134.725047));
            ShapeObjectMarks.AddLineTo(new CGPoint(150.543116, 133.916030));
            ShapeObjectMarks.AddLineTo(new CGPoint(157.015252, 138.618312));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(157.015252, 138.618312));
            ShapeObjectMarks.MoveTo(new CGPoint(151.786151, 145.158876));
            ShapeObjectMarks.AddLineTo(new CGPoint(151.117021, 145.902021));
            ShapeObjectMarks.AddLineTo(new CGPoint(145.171862, 140.548976));
            ShapeObjectMarks.AddLineTo(new CGPoint(145.840993, 139.805831));
            ShapeObjectMarks.AddLineTo(new CGPoint(151.786151, 145.158876));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(151.786151, 145.158876));
            ShapeObjectMarks.MoveTo(new CGPoint(145.902021, 151.117021));
            ShapeObjectMarks.AddLineTo(new CGPoint(145.158876, 151.786151));
            ShapeObjectMarks.AddLineTo(new CGPoint(139.805831, 145.840993));
            ShapeObjectMarks.AddLineTo(new CGPoint(140.548976, 145.171862));
            ShapeObjectMarks.AddLineTo(new CGPoint(145.902021, 151.117021));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(145.902021, 151.117021));
            ShapeObjectMarks.MoveTo(new CGPoint(139.427329, 156.427467));
            ShapeObjectMarks.AddLineTo(new CGPoint(138.618312, 157.015252));
            ShapeObjectMarks.AddLineTo(new CGPoint(133.916030, 150.543116));
            ShapeObjectMarks.AddLineTo(new CGPoint(134.725047, 149.955331));
            ShapeObjectMarks.AddLineTo(new CGPoint(139.427329, 156.427467));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(139.427329, 156.427467));
            ShapeObjectMarks.MoveTo(new CGPoint(138.433013, 171.228185));
            ShapeObjectMarks.AddLineTo(new CGPoint(137.566987, 171.728185));
            ShapeObjectMarks.AddLineTo(new CGPoint(127.566987, 154.407677));
            ShapeObjectMarks.AddLineTo(new CGPoint(128.433013, 153.907677));
            ShapeObjectMarks.AddLineTo(new CGPoint(138.433013, 171.228185));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(138.433013, 171.228185));
            ShapeObjectMarks.MoveTo(new CGPoint(124.995704, 164.880268));
            ShapeObjectMarks.AddLineTo(new CGPoint(124.082159, 165.287005));
            ShapeObjectMarks.AddLineTo(new CGPoint(120.828266, 157.978641));
            ShapeObjectMarks.AddLineTo(new CGPoint(121.741811, 157.571905));
            ShapeObjectMarks.AddLineTo(new CGPoint(124.995704, 164.880268));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(124.995704, 164.880268));
            ShapeObjectMarks.MoveTo(new CGPoint(117.196888, 167.930013));
            ShapeObjectMarks.AddLineTo(new CGPoint(116.245831, 168.239030));
            ShapeObjectMarks.AddLineTo(new CGPoint(113.773695, 160.630578));
            ShapeObjectMarks.AddLineTo(new CGPoint(114.724752, 160.321561));
            ShapeObjectMarks.AddLineTo(new CGPoint(117.196888, 167.930013));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(117.196888, 167.930013));
            ShapeObjectMarks.MoveTo(new CGPoint(109.122009, 170.147852));
            ShapeObjectMarks.AddLineTo(new CGPoint(108.143861, 170.355764));
            ShapeObjectMarks.AddLineTo(new CGPoint(106.480568, 162.530583));
            ShapeObjectMarks.AddLineTo(new CGPoint(107.458716, 162.322671));
            ShapeObjectMarks.AddLineTo(new CGPoint(109.122009, 170.147852));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(109.122009, 170.147852));
            ShapeObjectMarks.MoveTo(new CGPoint(100.859538, 171.509487));
            ShapeObjectMarks.AddLineTo(new CGPoint(99.865016, 171.614016));
            ShapeObjectMarks.AddLineTo(new CGPoint(99.028788, 163.657841));
            ShapeObjectMarks.AddLineTo(new CGPoint(100.023310, 163.553312));
            ShapeObjectMarks.AddLineTo(new CGPoint(100.859538, 171.509487));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(100.859538, 171.509487));
            ShapeObjectMarks.MoveTo(new CGPoint(92.500000, 184.000000));
            ShapeObjectMarks.AddLineTo(new CGPoint(91.500000, 184.000000));
            ShapeObjectMarks.AddLineTo(new CGPoint(91.500000, 164.000000));
            ShapeObjectMarks.AddLineTo(new CGPoint(92.500000, 164.000000));
            ShapeObjectMarks.AddLineTo(new CGPoint(92.500000, 184.000000));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(92.500000, 184.000000));
            ShapeObjectMarks.MoveTo(new CGPoint(84.134984, 171.614016));
            ShapeObjectMarks.AddLineTo(new CGPoint(83.140462, 171.509487));
            ShapeObjectMarks.AddLineTo(new CGPoint(83.976690, 163.553312));
            ShapeObjectMarks.AddLineTo(new CGPoint(84.971212, 163.657841));
            ShapeObjectMarks.AddLineTo(new CGPoint(84.134984, 171.614016));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(84.134984, 171.614016));
            ShapeObjectMarks.MoveTo(new CGPoint(75.856139, 170.355764));
            ShapeObjectMarks.AddLineTo(new CGPoint(74.877991, 170.147852));
            ShapeObjectMarks.AddLineTo(new CGPoint(76.541284, 162.322671));
            ShapeObjectMarks.AddLineTo(new CGPoint(77.519432, 162.530583));
            ShapeObjectMarks.AddLineTo(new CGPoint(75.856139, 170.355764));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(75.856139, 170.355764));
            ShapeObjectMarks.MoveTo(new CGPoint(67.754169, 168.239030));
            ShapeObjectMarks.AddLineTo(new CGPoint(66.803112, 167.930013));
            ShapeObjectMarks.AddLineTo(new CGPoint(69.275248, 160.321561));
            ShapeObjectMarks.AddLineTo(new CGPoint(70.226305, 160.630578));
            ShapeObjectMarks.AddLineTo(new CGPoint(67.754169, 168.239030));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(67.754169, 168.239030));
            ShapeObjectMarks.MoveTo(new CGPoint(59.917841, 165.287005));
            ShapeObjectMarks.AddLineTo(new CGPoint(59.004296, 164.880268));
            ShapeObjectMarks.AddLineTo(new CGPoint(62.258189, 157.571905));
            ShapeObjectMarks.AddLineTo(new CGPoint(63.171734, 157.978641));
            ShapeObjectMarks.AddLineTo(new CGPoint(59.917841, 165.287005));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(59.917841, 165.287005));
            ShapeObjectMarks.MoveTo(new CGPoint(46.433013, 171.728185));
            ShapeObjectMarks.AddLineTo(new CGPoint(45.566987, 171.228185));
            ShapeObjectMarks.AddLineTo(new CGPoint(55.566987, 153.907677));
            ShapeObjectMarks.AddLineTo(new CGPoint(56.433013, 154.407677));
            ShapeObjectMarks.AddLineTo(new CGPoint(46.433013, 171.728185));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(46.433013, 171.728185));
            ShapeObjectMarks.MoveTo(new CGPoint(45.381688, 157.015252));
            ShapeObjectMarks.AddLineTo(new CGPoint(44.572671, 156.427467));
            ShapeObjectMarks.AddLineTo(new CGPoint(49.274953, 149.955331));
            ShapeObjectMarks.AddLineTo(new CGPoint(50.083970, 150.543116));
            ShapeObjectMarks.AddLineTo(new CGPoint(45.381688, 157.015252));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(45.381688, 157.015252));
            ShapeObjectMarks.MoveTo(new CGPoint(38.841124, 151.786151));
            ShapeObjectMarks.AddLineTo(new CGPoint(38.097979, 151.117021));
            ShapeObjectMarks.AddLineTo(new CGPoint(43.451024, 145.171862));
            ShapeObjectMarks.AddLineTo(new CGPoint(44.194169, 145.840993));
            ShapeObjectMarks.AddLineTo(new CGPoint(38.841124, 151.786151));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(38.841124, 151.786151));
            ShapeObjectMarks.MoveTo(new CGPoint(32.882979, 145.902021));
            ShapeObjectMarks.AddLineTo(new CGPoint(32.213849, 145.158876));
            ShapeObjectMarks.AddLineTo(new CGPoint(38.159007, 139.805831));
            ShapeObjectMarks.AddLineTo(new CGPoint(38.828138, 140.548976));
            ShapeObjectMarks.AddLineTo(new CGPoint(32.882979, 145.902021));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(32.882979, 145.902021));
            ShapeObjectMarks.MoveTo(new CGPoint(27.572533, 139.427329));
            ShapeObjectMarks.AddLineTo(new CGPoint(26.984748, 138.618312));
            ShapeObjectMarks.AddLineTo(new CGPoint(33.456884, 133.916030));
            ShapeObjectMarks.AddLineTo(new CGPoint(34.044669, 134.725047));
            ShapeObjectMarks.AddLineTo(new CGPoint(27.572533, 139.427329));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(27.572533, 139.427329));
            ShapeObjectMarks.MoveTo(new CGPoint(12.771815, 138.433013));
            ShapeObjectMarks.AddLineTo(new CGPoint(12.271815, 137.566987));
            ShapeObjectMarks.AddLineTo(new CGPoint(29.592323, 127.566987));
            ShapeObjectMarks.AddLineTo(new CGPoint(30.092323, 128.433013));
            ShapeObjectMarks.AddLineTo(new CGPoint(12.771815, 138.433013));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(12.771815, 138.433013));
            ShapeObjectMarks.MoveTo(new CGPoint(19.119732, 124.995704));
            ShapeObjectMarks.AddLineTo(new CGPoint(18.712995, 124.082159));
            ShapeObjectMarks.AddLineTo(new CGPoint(26.021359, 120.828266));
            ShapeObjectMarks.AddLineTo(new CGPoint(26.428095, 121.741811));
            ShapeObjectMarks.AddLineTo(new CGPoint(19.119732, 124.995704));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(19.119732, 124.995704));
            ShapeObjectMarks.MoveTo(new CGPoint(16.069987, 117.196888));
            ShapeObjectMarks.AddLineTo(new CGPoint(15.760970, 116.245831));
            ShapeObjectMarks.AddLineTo(new CGPoint(23.369422, 113.773695));
            ShapeObjectMarks.AddLineTo(new CGPoint(23.678439, 114.724752));
            ShapeObjectMarks.AddLineTo(new CGPoint(16.069987, 117.196888));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(16.069987, 117.196888));
            ShapeObjectMarks.MoveTo(new CGPoint(13.852148, 109.122009));
            ShapeObjectMarks.AddLineTo(new CGPoint(13.644236, 108.143861));
            ShapeObjectMarks.AddLineTo(new CGPoint(21.469417, 106.480568));
            ShapeObjectMarks.AddLineTo(new CGPoint(21.677329, 107.458716));
            ShapeObjectMarks.AddLineTo(new CGPoint(13.852148, 109.122009));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(13.852148, 109.122009));
            ShapeObjectMarks.MoveTo(new CGPoint(12.490513, 100.859538));
            ShapeObjectMarks.AddLineTo(new CGPoint(12.385984, 99.865016));
            ShapeObjectMarks.AddLineTo(new CGPoint(20.342159, 99.028788));
            ShapeObjectMarks.AddLineTo(new CGPoint(20.446688, 100.023310));
            ShapeObjectMarks.AddLineTo(new CGPoint(12.490513, 100.859538));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(12.490513, 100.859538));
            ShapeObjectMarks.MoveTo(new CGPoint(0.000000, 92.500000));
            ShapeObjectMarks.AddLineTo(new CGPoint(0.000000, 91.500000));
            ShapeObjectMarks.AddLineTo(new CGPoint(20.000000, 91.500000));
            ShapeObjectMarks.AddLineTo(new CGPoint(20.000000, 92.500000));
            ShapeObjectMarks.AddLineTo(new CGPoint(0.000000, 92.500000));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(0.000000, 92.500000));
            ShapeObjectMarks.MoveTo(new CGPoint(12.385984, 84.134984));
            ShapeObjectMarks.AddLineTo(new CGPoint(12.490513, 83.140462));
            ShapeObjectMarks.AddLineTo(new CGPoint(20.446688, 83.976690));
            ShapeObjectMarks.AddLineTo(new CGPoint(20.342159, 84.971212));
            ShapeObjectMarks.AddLineTo(new CGPoint(12.385984, 84.134984));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(12.385984, 84.134984));
            ShapeObjectMarks.MoveTo(new CGPoint(13.644236, 75.856139));
            ShapeObjectMarks.AddLineTo(new CGPoint(13.852148, 74.877991));
            ShapeObjectMarks.AddLineTo(new CGPoint(21.677329, 76.541284));
            ShapeObjectMarks.AddLineTo(new CGPoint(21.469417, 77.519432));
            ShapeObjectMarks.AddLineTo(new CGPoint(13.644236, 75.856139));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(13.644236, 75.856139));
            ShapeObjectMarks.MoveTo(new CGPoint(15.760970, 67.754169));
            ShapeObjectMarks.AddLineTo(new CGPoint(16.069987, 66.803112));
            ShapeObjectMarks.AddLineTo(new CGPoint(23.678439, 69.275248));
            ShapeObjectMarks.AddLineTo(new CGPoint(23.369422, 70.226305));
            ShapeObjectMarks.AddLineTo(new CGPoint(15.760970, 67.754169));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(15.760970, 67.754169));
            ShapeObjectMarks.MoveTo(new CGPoint(18.712995, 59.917841));
            ShapeObjectMarks.AddLineTo(new CGPoint(19.119732, 59.004296));
            ShapeObjectMarks.AddLineTo(new CGPoint(26.428095, 62.258189));
            ShapeObjectMarks.AddLineTo(new CGPoint(26.021359, 63.171734));
            ShapeObjectMarks.AddLineTo(new CGPoint(18.712995, 59.917841));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(18.712995, 59.917841));
            ShapeObjectMarks.MoveTo(new CGPoint(12.271815, 46.433013));
            ShapeObjectMarks.AddLineTo(new CGPoint(12.771815, 45.566987));
            ShapeObjectMarks.AddLineTo(new CGPoint(30.092323, 55.566987));
            ShapeObjectMarks.AddLineTo(new CGPoint(29.592323, 56.433013));
            ShapeObjectMarks.AddLineTo(new CGPoint(12.271815, 46.433013));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(12.271815, 46.433013));
            ShapeObjectMarks.MoveTo(new CGPoint(26.984748, 45.381688));
            ShapeObjectMarks.AddLineTo(new CGPoint(27.572533, 44.572671));
            ShapeObjectMarks.AddLineTo(new CGPoint(34.044669, 49.274953));
            ShapeObjectMarks.AddLineTo(new CGPoint(33.456884, 50.083970));
            ShapeObjectMarks.AddLineTo(new CGPoint(26.984748, 45.381688));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(26.984748, 45.381688));
            ShapeObjectMarks.MoveTo(new CGPoint(32.213849, 38.841124));
            ShapeObjectMarks.AddLineTo(new CGPoint(32.882979, 38.097979));
            ShapeObjectMarks.AddLineTo(new CGPoint(38.828138, 43.451024));
            ShapeObjectMarks.AddLineTo(new CGPoint(38.159007, 44.194169));
            ShapeObjectMarks.AddLineTo(new CGPoint(32.213849, 38.841124));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(32.213849, 38.841124));
            ShapeObjectMarks.MoveTo(new CGPoint(38.097979, 32.882979));
            ShapeObjectMarks.AddLineTo(new CGPoint(38.841124, 32.213849));
            ShapeObjectMarks.AddLineTo(new CGPoint(44.194169, 38.159007));
            ShapeObjectMarks.AddLineTo(new CGPoint(43.451024, 38.828138));
            ShapeObjectMarks.AddLineTo(new CGPoint(38.097979, 32.882979));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(38.097979, 32.882979));
            ShapeObjectMarks.MoveTo(new CGPoint(44.572671, 27.572533));
            ShapeObjectMarks.AddLineTo(new CGPoint(45.381688, 26.984748));
            ShapeObjectMarks.AddLineTo(new CGPoint(50.083970, 33.456884));
            ShapeObjectMarks.AddLineTo(new CGPoint(49.274953, 34.044669));
            ShapeObjectMarks.AddLineTo(new CGPoint(44.572671, 27.572533));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(44.572671, 27.572533));
            ShapeObjectMarks.MoveTo(new CGPoint(45.566987, 12.771815));
            ShapeObjectMarks.AddLineTo(new CGPoint(46.433013, 12.271815));
            ShapeObjectMarks.AddLineTo(new CGPoint(56.433013, 29.592323));
            ShapeObjectMarks.AddLineTo(new CGPoint(55.566987, 30.092323));
            ShapeObjectMarks.AddLineTo(new CGPoint(45.566987, 12.771815));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(45.566987, 12.771815));
            ShapeObjectMarks.MoveTo(new CGPoint(59.004296, 19.119732));
            ShapeObjectMarks.AddLineTo(new CGPoint(59.917841, 18.712995));
            ShapeObjectMarks.AddLineTo(new CGPoint(63.171734, 26.021359));
            ShapeObjectMarks.AddLineTo(new CGPoint(62.258189, 26.428095));
            ShapeObjectMarks.AddLineTo(new CGPoint(59.004296, 19.119732));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(59.004296, 19.119732));
            ShapeObjectMarks.MoveTo(new CGPoint(66.803112, 16.069987));
            ShapeObjectMarks.AddLineTo(new CGPoint(67.754169, 15.760970));
            ShapeObjectMarks.AddLineTo(new CGPoint(70.226305, 23.369422));
            ShapeObjectMarks.AddLineTo(new CGPoint(69.275248, 23.678439));
            ShapeObjectMarks.AddLineTo(new CGPoint(66.803112, 16.069987));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(66.803112, 16.069987));
            ShapeObjectMarks.MoveTo(new CGPoint(74.877991, 13.852148));
            ShapeObjectMarks.AddLineTo(new CGPoint(75.856139, 13.644236));
            ShapeObjectMarks.AddLineTo(new CGPoint(77.519432, 21.469417));
            ShapeObjectMarks.AddLineTo(new CGPoint(76.541284, 21.677329));
            ShapeObjectMarks.AddLineTo(new CGPoint(74.877991, 13.852148));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(74.877991, 13.852148));
            ShapeObjectMarks.MoveTo(new CGPoint(83.140462, 12.490513));
            ShapeObjectMarks.AddLineTo(new CGPoint(84.134984, 12.385984));
            ShapeObjectMarks.AddLineTo(new CGPoint(84.971212, 20.342159));
            ShapeObjectMarks.AddLineTo(new CGPoint(83.976690, 20.446688));
            ShapeObjectMarks.AddLineTo(new CGPoint(83.140462, 12.490513));
            ShapeObjectMarks.ClosePath();
            ShapeObjectMarks.MoveTo(new CGPoint(83.140462, 12.490513));

            context.SaveState();
            context.SetAlpha(0.552764f);
            context.BeginTransparencyLayer(null);

            context.SaveState();
            context.TranslateCTM(0.000000f, 0.000000f);

            // Shape Fill
            ShapeObjectMarks.UsesEvenOddFillRule = true;
            context.SaveState();
            UIColor.FromHSBA(0.000000f, 0.000000f, 1.000000f, 1.000000f).SetFill();
            ShapeObjectMarks.Fill();
            context.RestoreState();

            context.RestoreState();

            context.EndTransparencyLayer();
            context.RestoreState();

        }

        //
        // ShapeObjectFillOval
        //
        private void DrawShapeObjectFillOval(CGContext context)
        {
            UIBezierPath ShapeObjectFillOval;

            // Shape Path
            ShapeObjectFillOval = new UIBezierPath();
            ShapeObjectFillOval.MoveTo(new CGPoint(71.500000, 143.000000));
            ShapeObjectFillOval.AddCurveToPoint(new CGPoint(143.000000, 71.500000), new CGPoint(110.988360, 143.000000), new CGPoint(143.000000, 110.988360));
            ShapeObjectFillOval.AddCurveToPoint(new CGPoint(71.500000, 0.000000), new CGPoint(143.000000, 32.011640), new CGPoint(110.988360, 0.000000));
            ShapeObjectFillOval.AddCurveToPoint(new CGPoint(0.000000, 71.500000), new CGPoint(32.011640, 0.000000), new CGPoint(0.000000, 32.011640));
            ShapeObjectFillOval.AddCurveToPoint(new CGPoint(71.500000, 143.000000), new CGPoint(0.000000, 110.988360), new CGPoint(32.011640, 143.000000));
            ShapeObjectFillOval.ClosePath();
            ShapeObjectFillOval.MoveTo(new CGPoint(71.500000, 143.000000));

            context.SaveState();
            context.TranslateCTM(21.000000f, 21.000000f);

            // Shape Fill
            ShapeObjectFillOval.UsesEvenOddFillRule = true;
            context.SaveState();
            ShapeObjectFillOval.AddClip();
            context.TranslateCTM(71.500000f, 107.492188f);
            context.RotateCTM(2.06761474261241E-13f);
            context.ScaleCTM(1.000000f, 1);
            FillRadialGradient(context,
              new CGPoint(0, 0),
              new CGPoint(0, 0),
              new nfloat[] { 0.000000f, 1.000000f },
              new CGColor[] {
                UIColor.FromHSBA(0.000000f, 0.000000f, 0.122608f, 1.000000f).CGColor,
                UIColor.FromHSBA(0.000000f, 0.000000f, 0.343909f, 1.000000f).CGColor
              }, 0, 133.910157f);
            context.RestoreState();

            context.RestoreState();

        }

        //
        // ShapeObjectBackOval
        //
        private void DrawShapeObjectBackOval(CGContext context)
        {
            UIBezierPath ShapeObjectBackOval;

            // Shape Path
            ShapeObjectBackOval = new UIBezierPath();
            ShapeObjectBackOval.MoveTo(new CGPoint(66.500000, 133.000000));
            ShapeObjectBackOval.AddCurveToPoint(new CGPoint(133.000000, 66.500000), new CGPoint(103.226936, 133.000000), new CGPoint(133.000000, 103.226936));
            ShapeObjectBackOval.AddCurveToPoint(new CGPoint(66.500000, 0.000000), new CGPoint(133.000000, 29.773064), new CGPoint(103.226936, 0.000000));
            ShapeObjectBackOval.AddCurveToPoint(new CGPoint(0.000000, 66.500000), new CGPoint(29.773064, 0.000000), new CGPoint(0.000000, 29.773064));
            ShapeObjectBackOval.AddCurveToPoint(new CGPoint(66.500000, 133.000000), new CGPoint(0.000000, 103.226936), new CGPoint(29.773064, 133.000000));
            ShapeObjectBackOval.ClosePath();
            ShapeObjectBackOval.MoveTo(new CGPoint(66.500000, 133.000000));

            context.SaveState();
            context.SetAlpha(0.800000f);
            context.BeginTransparencyLayer(null);

            context.SaveState();
            context.TranslateCTM(26.000000f, 26.000000f);

            // Shape Fill
            ShapeObjectBackOval.UsesEvenOddFillRule = true;
            context.SaveState();
            UIColor.FromHSBA(0.000000f, 0.000000f, 0.155533f, 1.000000f).SetFill();
            ShapeObjectBackOval.Fill();
            context.RestoreState();

            context.RestoreState();

            context.EndTransparencyLayer();
            context.RestoreState();

        }

        //
        // GroupObjectKnobGroup
        //
        private void DrawGroupObjectKnobGroup(CGContext context)
        {
            context.SaveState();

            context.TranslateCTM(10.000000f, 10.000000f);

            DrawShapeObjectMainHandle(context);
            DrawShapeObjectOvalStroke(context);
            DrawShapeObjectHandle2(context);
            DrawShapeObjectHandle1(context);

            // ~ End GroupObjectKnobGroup
            context.RestoreState();

        }

        //
        // ShapeObjectMainHandle
        //
        private void DrawShapeObjectMainHandle(CGContext context)
        {
            UIBezierPath ShapeObjectMainHandle;

            // Shape Path
            ShapeObjectMainHandle = new UIBezierPath();
            ShapeObjectMainHandle.MoveTo(new CGPoint(78.389317, 125.689697));
            ShapeObjectMainHandle.AddCurveToPoint(new CGPoint(47.251388, 125.689697), new CGPoint(69.790816, 123.669244), new CGPoint(55.840916, 123.671353));
            ShapeObjectMainHandle.AddLineTo(new CGPoint(51.218793, 124.757447));
            ShapeObjectMainHandle.AddCurveToPoint(new CGPoint(27.227755, 114.820033), new CGPoint(42.620292, 126.777899), new CGPoint(31.874283, 122.320931));
            ShapeObjectMainHandle.AddLineTo(new CGPoint(29.373934, 118.284612));
            ShapeObjectMainHandle.AddCurveToPoint(new CGPoint(7.356093, 96.266772), new CGPoint(24.722551, 110.775878), new CGPoint(14.856991, 100.913300));
            ShapeObjectMainHandle.AddLineTo(new CGPoint(10.820672, 98.412951));
            ShapeObjectMainHandle.AddCurveToPoint(new CGPoint(0.883259, 74.421912), new CGPoint(3.311938, 93.761568), new CGPoint(-1.135085, 83.011439));
            ShapeObjectMainHandle.AddLineTo(new CGPoint(-0.048991, 78.389317));
            ShapeObjectMainHandle.AddCurveToPoint(new CGPoint(-0.048991, 47.251388), new CGPoint(1.971461, 69.790816), new CGPoint(1.969353, 55.840916));
            ShapeObjectMainHandle.AddLineTo(new CGPoint(0.883259, 51.218793));
            ShapeObjectMainHandle.AddCurveToPoint(new CGPoint(10.820672, 27.227755), new CGPoint(-1.137194, 42.620292), new CGPoint(3.319775, 31.874283));
            ShapeObjectMainHandle.AddLineTo(new CGPoint(7.356093, 29.373934));
            ShapeObjectMainHandle.AddCurveToPoint(new CGPoint(29.373934, 7.356093), new CGPoint(14.864828, 24.722551), new CGPoint(24.727405, 14.856991));
            ShapeObjectMainHandle.AddLineTo(new CGPoint(27.227755, 10.820672));
            ShapeObjectMainHandle.AddCurveToPoint(new CGPoint(51.218793, 0.883259), new CGPoint(31.879138, 3.311938), new CGPoint(42.629266, -1.135085));
            ShapeObjectMainHandle.AddLineTo(new CGPoint(47.251388, -0.048991));
            ShapeObjectMainHandle.AddCurveToPoint(new CGPoint(78.389317, -0.048991), new CGPoint(55.849890, 1.971461), new CGPoint(69.799790, 1.969353));
            ShapeObjectMainHandle.AddLineTo(new CGPoint(74.421912, 0.883259));
            ShapeObjectMainHandle.AddCurveToPoint(new CGPoint(98.412951, 10.820672), new CGPoint(83.020414, -1.137194), new CGPoint(93.766422, 3.319775));
            ShapeObjectMainHandle.AddLineTo(new CGPoint(96.266772, 7.356093));
            ShapeObjectMainHandle.AddCurveToPoint(new CGPoint(118.284612, 29.373934), new CGPoint(100.918155, 14.864828), new CGPoint(110.783715, 24.727405));
            ShapeObjectMainHandle.AddLineTo(new CGPoint(114.820033, 27.227755));
            ShapeObjectMainHandle.AddCurveToPoint(new CGPoint(124.757447, 51.218793), new CGPoint(122.328768, 31.879138), new CGPoint(126.775790, 42.629266));
            ShapeObjectMainHandle.AddLineTo(new CGPoint(125.689697, 47.251388));
            ShapeObjectMainHandle.AddCurveToPoint(new CGPoint(125.689697, 78.389317), new CGPoint(123.669244, 55.849890), new CGPoint(123.671353, 69.799790));
            ShapeObjectMainHandle.AddLineTo(new CGPoint(124.757447, 74.421912));
            ShapeObjectMainHandle.AddCurveToPoint(new CGPoint(114.820033, 98.412951), new CGPoint(126.777899, 83.020414), new CGPoint(122.320931, 93.766422));
            ShapeObjectMainHandle.AddLineTo(new CGPoint(118.284612, 96.266772));
            ShapeObjectMainHandle.AddCurveToPoint(new CGPoint(96.266772, 118.284612), new CGPoint(110.775878, 100.918155), new CGPoint(100.913300, 110.783715));
            ShapeObjectMainHandle.AddLineTo(new CGPoint(98.412951, 114.820033));
            ShapeObjectMainHandle.AddCurveToPoint(new CGPoint(74.421912, 124.757447), new CGPoint(93.761568, 122.328768), new CGPoint(83.011439, 126.775790));
            ShapeObjectMainHandle.AddLineTo(new CGPoint(78.389317, 125.689697));
            ShapeObjectMainHandle.ClosePath();
            ShapeObjectMainHandle.MoveTo(new CGPoint(78.389317, 125.689697));

            context.SaveState();
            context.TranslateCTM(81.8203544616699f, 81.8203544616699f);
            context.RotateCTM(0.383972435438778f);
            context.TranslateCTM(-62.8203544616699f, -62.8203544616699f);

            // Shape Outer Shadow
            context.SaveState();
            context.BeginPath();
            context.AddPath(ShapeObjectMainHandle.CGPath);
            context.AddRect(RectangleFExtensions.Inset(ShapeObjectMainHandle.Bounds, -18.4f, -19.4f));
            context.EOClip();
            context.TranslateCTM(-160.44070892334f, 0f);

            GenerateShapeShadow(context, ShapeObjectMainHandle, 160.44070892334f, 1f, 53.4802363077799f, 0, UIColor.FromHSBA(0.000000f, 0.000000f, 0.000000f, 0.500000f), 1.54f, 1, -15.4f, -15.4f);
            context.RestoreState();

            // Shape Fill
            ShapeObjectMainHandle.UsesEvenOddFillRule = true;
            context.SaveState();
            ShapeObjectMainHandle.AddClip();
            FillLinearGradient(context,
              new CGPoint(36.134706f, 0.000000f),
              new CGPoint(79.314314f, 102.069878f),
              new nfloat[] { 0.000000f, 1.000000f },
              new CGColor[] {
                UIColor.FromHSBA(0.128708f, 0.071062f, 0.379571f, 1.000000f).CGColor,
                UIColor.FromHSBA(0.113451f, 0.109631f, 0.239424f, 1.000000f).CGColor
              });
            context.RestoreState();

            context.SaveState();
            context.SetBlendMode(CGBlendMode.Color);
            context.BeginTransparencyLayer(ShapeObjectMainHandle.Bounds, null);
            UIColor.FromHSBA(0.000000f, 0.000000f, 0.000000f, 1.000000f).SetFill();
            ShapeObjectMainHandle.Fill();
            context.EndTransparencyLayer();
            context.RestoreState();

            // Shape Inner Shadow
            context.SaveState();
            UIGraphics.RectClip(ShapeObjectMainHandle.Bounds);
            context.SetShadow(new CGSize(0, 0), 0, null);
            context.SetAlpha(0.500000f);
            context.BeginTransparencyLayer(ShapeObjectMainHandle.Bounds, null);
            UIColor.FromHSBA(0.000000f, 0.000000f, 0.000000f, 1.0f).SetFill();
            ShapeObjectMainHandle.Fill();
            context.SetBlendMode(CGBlendMode.DestinationOut);
            context.BeginTransparencyLayer(ShapeObjectMainHandle.Bounds, null);
            context.TranslateCTM(-125.64070892334f, 0f);
            GenerateShapeInnerShadow(context, 125.64070892334f, 1f, 125.64070892334f);
            UIColor.Black.SetFill();
            ShapeObjectMainHandle.Fill();
            context.EndTransparencyLayer();
            context.EndTransparencyLayer();
            context.RestoreState();

            // Shape Stroke
            context.SaveState();
            ShapeObjectMainHandle.LineWidth = 1.54f;
            context.BeginPath();
            context.AddPath(ShapeObjectMainHandle.CGPath);
            context.EOClip();
            UIColor.FromHSBA(0.000000f, 0.000000f, 0.000000f, 0.408939f).SetStroke();
            ShapeObjectMainHandle.Stroke();

            context.RestoreState();
            context.RestoreState();

        }

        //
        // ShapeObjectOvalStroke
        //
        private void DrawShapeObjectOvalStroke(CGContext context)
        {
            UIBezierPath ShapeObjectOvalStroke;

            // Shape Path
            ShapeObjectOvalStroke = new UIBezierPath();
            ShapeObjectOvalStroke.MoveTo(new CGPoint(52.000000, 104.000000));
            ShapeObjectOvalStroke.AddCurveToPoint(new CGPoint(104.000000, 52.000000), new CGPoint(80.718807, 104.000000), new CGPoint(104.000000, 80.718807));
            ShapeObjectOvalStroke.AddCurveToPoint(new CGPoint(52.000000, 0.000000), new CGPoint(104.000000, 23.281193), new CGPoint(80.718807, 0.000000));
            ShapeObjectOvalStroke.AddCurveToPoint(new CGPoint(0.000000, 52.000000), new CGPoint(23.281193, 0.000000), new CGPoint(0.000000, 23.281193));
            ShapeObjectOvalStroke.AddCurveToPoint(new CGPoint(52.000000, 104.000000), new CGPoint(0.000000, 80.718807), new CGPoint(23.281193, 104.000000));
            ShapeObjectOvalStroke.ClosePath();
            ShapeObjectOvalStroke.MoveTo(new CGPoint(52.000000, 104.000000));

            context.SaveState();
            context.TranslateCTM(30.000000f, 30.000000f);

            // Shape Inner Shadow
            context.SaveState();
            UIGraphics.RectClip(ShapeObjectOvalStroke.Bounds);
            context.SetShadow(new CGSize(0, 0), 0, null);
            context.SetAlpha(0.500000f);
            context.BeginTransparencyLayer(ShapeObjectOvalStroke.Bounds, null);
            UIColor.FromHSBA(0.000000f, 0.000000f, 1.000000f, 1.0f).SetFill();
            ShapeObjectOvalStroke.Fill();
            context.SetBlendMode(CGBlendMode.DestinationOut);
            context.BeginTransparencyLayer(ShapeObjectOvalStroke.Bounds, null);
            context.TranslateCTM(-104f, 0f);
            GenerateShapeInnerShadow(context, 104f, 1f, 34.6666666666667f);
            UIColor.Black.SetFill();
            ShapeObjectOvalStroke.Fill();
            context.EndTransparencyLayer();
            context.EndTransparencyLayer();
            context.RestoreState();

            // Shape Stroke
            context.SaveState();
            ShapeObjectOvalStroke.LineWidth = 4f;
            context.BeginPath();
            context.AddPath(ShapeObjectOvalStroke.CGPath);
            context.EOClip();
            UIColor.FromHSBA(0.110960f, 0.092586f, 0.175276f, 1.000000f).SetStroke();
            ShapeObjectOvalStroke.Stroke();

            context.RestoreState();
            context.RestoreState();

        }

        //
        // ShapeObjectHandle2
        //
        private void DrawShapeObjectHandle2(CGContext context)
        {
            UIBezierPath ShapeObjectHandle2;

            // Shape Path
            ShapeObjectHandle2 = new UIBezierPath();
            ShapeObjectHandle2.MoveTo(new CGPoint(4.500000, 9.000000));
            ShapeObjectHandle2.AddCurveToPoint(new CGPoint(9.000000, 4.500000), new CGPoint(6.985281, 9.000000), new CGPoint(9.000000, 6.985281));
            ShapeObjectHandle2.AddCurveToPoint(new CGPoint(4.500000, 0.000000), new CGPoint(9.000000, 2.014719), new CGPoint(6.985281, 0.000000));
            ShapeObjectHandle2.AddCurveToPoint(new CGPoint(0.000000, 4.500000), new CGPoint(2.014719, 0.000000), new CGPoint(0.000000, 2.014719));
            ShapeObjectHandle2.AddCurveToPoint(new CGPoint(4.500000, 9.000000), new CGPoint(0.000000, 6.985281), new CGPoint(2.014719, 9.000000));
            ShapeObjectHandle2.ClosePath();
            ShapeObjectHandle2.MoveTo(new CGPoint(4.500000, 9.000000));

            context.SaveState();
            context.TranslateCTM(78.000000f, 26.000000f);

            // Shape Fill
            ShapeObjectHandle2.UsesEvenOddFillRule = true;
            context.SaveState();
            UIColor.FromHSBA(0.589719f, 0.562401f, 0.957297f, 1.000000f).SetFill();
            ShapeObjectHandle2.Fill();
            context.RestoreState();

            context.RestoreState();

        }

        //
        // ShapeObjectHandle1
        //
        private void DrawShapeObjectHandle1(CGContext context)
        {
            UIBezierPath ShapeObjectHandle1;

            // Shape Path
            ShapeObjectHandle1 = new UIBezierPath();
            ShapeObjectHandle1.MoveTo(new CGPoint(4.500000, 9.000000));
            ShapeObjectHandle1.AddCurveToPoint(new CGPoint(9.000000, 4.500000), new CGPoint(6.985281, 9.000000), new CGPoint(9.000000, 6.985281));
            ShapeObjectHandle1.AddCurveToPoint(new CGPoint(4.500000, 0.000000), new CGPoint(9.000000, 2.014719), new CGPoint(6.985281, 0.000000));
            ShapeObjectHandle1.AddCurveToPoint(new CGPoint(0.000000, 4.500000), new CGPoint(2.014719, 0.000000), new CGPoint(0.000000, 2.014719));
            ShapeObjectHandle1.AddCurveToPoint(new CGPoint(4.500000, 9.000000), new CGPoint(0.000000, 6.985281), new CGPoint(2.014719, 9.000000));
            ShapeObjectHandle1.ClosePath();
            ShapeObjectHandle1.MoveTo(new CGPoint(4.500000, 9.000000));

            context.SaveState();
            context.TranslateCTM(78.000000f, 26.000000f);

            // Shape Fill
            ShapeObjectHandle1.UsesEvenOddFillRule = true;
            context.SaveState();
            UIColor.FromHSBA(0.589719f, 0.084616f, 1.000000f, 1.000000f).SetFill();
            ShapeObjectHandle1.Fill();
            context.RestoreState();

            context.RestoreState();

        }

        CGPoint RotatePoint(double cx, double cy, double angle, CGPoint p)
        {
            double s = Math.Sin(angle);
            double c = Math.Cos(angle);

            // translate point back to origin:
            p.X -= (nfloat) cx;
            p.Y -= (nfloat) cy;

            // rotate point
            double xnew = p.X * c - p.Y * s;
            double ynew = p.X * s + p.Y * c;

            // translate point back:
            return new CGPoint((nfloat)(xnew + cx), (nfloat)(ynew + cy));
        }

        //
        // UIImage export
        //
        public UIImage GenerateArtboardKnobDrawingBitmap()
        {
            UIGraphics.BeginImageContextWithOptions(new CGSize(artboardKnobDrawingWidth, artboardKnobDrawingHeight), false, 0);
            DrawArtboardKnobDrawing(new CGRect(new CGPoint(0, 0), new CGSize(artboardKnobDrawingWidth, artboardKnobDrawingHeight)), 
                                    artboardKnobDrawingFillMode);
            UIImage nativeImage = UIGraphics.GetImageFromCurrentImageContext();
            UIGraphics.EndImageContext();

            return nativeImage;
        }

        //
        // Resizing logic for ArtboardKnobDrawing
        //
        private CGRect GetNewArtboardSize(ArtboardKnobDrawingFillMode fillMode, CGRect sourceRect, CGRect targetRect)
        {
            CGSize scales = new CGSize(0, 0);
            CGSize sizeZero = new CGSize(0, 0);
            CGRect rectZero = new CGRect(0, 0, 0, 0);


            if (sourceRect == targetRect || targetRect == rectZero)
            {
                return sourceRect;
            }
            else
            {
                scales = sizeZero;
                scales.Width = (nfloat)Math.Abs(targetRect.Width / sourceRect.Width);
                scales.Height = (nfloat)Math.Abs(targetRect.Height / sourceRect.Height);

                if (fillMode == ArtboardKnobDrawingFillMode.ArtboardKnobDrawingFit)
                {
                    scales.Width = (nfloat)Math.Min(scales.Width, scales.Height);
                    scales.Height = (nfloat)scales.Width;
                }
                else if (fillMode == ArtboardKnobDrawingFillMode.ArtboardKnobDrawingFill)
                {
                    scales.Width = (nfloat)Math.Max(scales.Width, scales.Height);
                    scales.Height = scales.Width;
                }
                else if (fillMode == ArtboardKnobDrawingFillMode.ArtboardKnobDrawingOriginal)
                {
                    scales.Width = 1;
                    scales.Height = 1;
                }

                if (sourceRect.Width < 0)
                {
                    sourceRect.X = sourceRect.X + sourceRect.Width;
                    sourceRect.Width = (nfloat)Math.Abs(sourceRect.Width);
                }
                if (sourceRect.Height < 0)
                {
                    sourceRect.Y = sourceRect.Y + sourceRect.Height;
                    sourceRect.Height = (nfloat)Math.Abs(sourceRect.Height);
                }

                nfloat newWidth = sourceRect.Width * scales.Width;
                nfloat newHeight = sourceRect.Height * scales.Height;
                nfloat newLeft = targetRect.X + (targetRect.Width - newWidth) / 2;
                nfloat newTop = targetRect.Y + (targetRect.Height - newHeight) / 2;

                return new CGRect(newLeft, newTop, newWidth, newHeight);
            }
        }

        //
        // Helper function to generate inner shadow
        //
        public void GenerateShapeInnerShadow(CGContext context, nfloat xOffset, nfloat yOffset, nfloat blurValue)
        {
            CGPoint basePoint;
            CGPoint offsetPoint;
            CGSize calculatedShadowOffset;
            nfloat calculatedShadowBlur;
            CGPoint constPointZero;

            constPointZero = new CGPoint(0, 0);

            basePoint = baseTransform.TransformPoint(context.PointToDeviceSpace(constPointZero));
            offsetPoint = baseTransform.TransformPoint(context.PointToDeviceSpace(new CGPoint(xOffset, yOffset)));
            calculatedShadowOffset = new CGSize(offsetPoint.X - basePoint.X, offsetPoint.Y - basePoint.Y);
            if (blurValue == 0)
            {
                calculatedShadowBlur = 0;
            }
            else
            {
                calculatedShadowBlur = Hypot(calculatedShadowOffset.Width, calculatedShadowOffset.Height) / blurValue;
            }
            context.SetShadow(calculatedShadowOffset, calculatedShadowBlur, UIColor.Black.CGColor);
        }

        //
        // Helper function to generate shadow
        //
        private void GenerateShapeShadow(CGContext context, UIBezierPath shapeObject, nfloat xOffset, nfloat yOffset, nfloat blurValue, CGBlendMode blendingMode, UIColor shadowColor, nfloat borderWidth, int borderPosition, nfloat iWidth, nfloat iHeight)
        {
            CGPoint basePoint;
            CGPoint offsetPoint;
            CGSize calculatedShadowOffset;
            nfloat calculatedShadowBlur;
            CGPoint constPointZero;

            constPointZero = new CGPoint(0, 0);

            basePoint = baseTransform.TransformPoint(context.PointToDeviceSpace(constPointZero));
            offsetPoint = baseTransform.TransformPoint(context.PointToDeviceSpace(new CGPoint(xOffset, yOffset)));
            calculatedShadowOffset = new CGSize(offsetPoint.X - basePoint.X, offsetPoint.Y - basePoint.Y);
            if (blurValue == 0)
            {
                calculatedShadowBlur = 0;
            }
            else
            {
                calculatedShadowBlur = Hypot(calculatedShadowOffset.Width, calculatedShadowOffset.Height) / blurValue;
            }
            context.SetShadow(calculatedShadowOffset, calculatedShadowBlur, shadowColor.CGColor);
            context.SetBlendMode(blendingMode);

            context.BeginTransparencyLayer(null);

            UIColor.Black.SetFill();
            shapeObject.Fill();

            if (borderWidth > 0)
            {
                if (borderPosition == 0)
                {
                    context.SaveState();
                    shapeObject.LineWidth = borderWidth;
                    UIColor.Black.SetStroke();
                    shapeObject.Stroke();
                    context.RestoreState();
                }

                if (borderPosition == 1)
                {
                    context.BeginPath();
                    context.AddPath(shapeObject.CGPath);
                    context.EOClip();
                }

                if (borderPosition == 2)
                {
                    context.BeginPath();
                    context.AddPath(shapeObject.CGPath);
                    context.AddRect(RectangleFExtensions.Inset(shapeObject.Bounds, iWidth, iHeight));
                    context.EOClip();
                }
            }

            context.EndTransparencyLayer();
        }

        //
        // Helper function to compute hypotenuse
        //
        private nfloat Hypot(nfloat a, nfloat b)
        {
            return (nfloat)Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }

        //
        // Helper function to generate gradient fill
        //
        private void FillLinearGradient(CGContext context, CGPoint startPoint, CGPoint endPoint, nfloat[] stops, CGColor[] gradientColors)
        {

            CGColorSpace colorSpace = CGColorSpace.CreateDeviceRGB();
            CGGradient gradient = new CGGradient(colorSpace, gradientColors, stops);

            context.DrawLinearGradient(gradient, startPoint, endPoint, CGGradientDrawingOptions.DrawsBeforeStartLocation | CGGradientDrawingOptions.DrawsAfterEndLocation);
        }
        //
        // Helper function to generate radial gradient fill
        //
        private void FillRadialGradient(CGContext context, CGPoint startPoint, CGPoint endPoint, nfloat[] stops, CGColor[] gradientColors, nfloat startRadius, nfloat endRadius)
        {

            CGColorSpace colorSpace = CGColorSpace.CreateDeviceRGB();
            CGGradient gradient = new CGGradient(colorSpace, gradientColors, stops);

            context.DrawRadialGradient(gradient, startPoint, startRadius, endPoint, endRadius, CGGradientDrawingOptions.DrawsBeforeStartLocation | CGGradientDrawingOptions.DrawsAfterEndLocation);
        }
    }
}
