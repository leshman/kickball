// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace KickballScoreKeeper
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField balls { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnClearVisitorScore { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField fouls { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField homeScore { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField outs { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField strikes { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtHome { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtVisitor { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField vistorScore { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIStepper vistorScoreStepper { get; set; }

        [Action ("clearVisitorClicked:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void clearVisitorClicked (UIKit.UIButton sender);

        [Action ("vistorScoreChange:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void vistorScoreChange (UIKit.UIStepper sender);

        void ReleaseDesignerOutlets ()
        {
            if (balls != null) {
                balls.Dispose ();
                balls = null;
            }

            if (btnClearVisitorScore != null) {
                btnClearVisitorScore.Dispose ();
                btnClearVisitorScore = null;
            }

            if (fouls != null) {
                fouls.Dispose ();
                fouls = null;
            }

            if (homeScore != null) {
                homeScore.Dispose ();
                homeScore = null;
            }

            if (outs != null) {
                outs.Dispose ();
                outs = null;
            }

            if (strikes != null) {
                strikes.Dispose ();
                strikes = null;
            }

            if (txtHome != null) {
                txtHome.Dispose ();
                txtHome = null;
            }

            if (txtVisitor != null) {
                txtVisitor.Dispose ();
                txtVisitor = null;
            }

            if (vistorScore != null) {
                vistorScore.Dispose ();
                vistorScore = null;
            }

            if (vistorScoreStepper != null) {
                vistorScoreStepper.Dispose ();
                vistorScoreStepper = null;
            }
        }
    }
}