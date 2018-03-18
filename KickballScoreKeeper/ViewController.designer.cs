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
        UIKit.UIStepper ballsStepper { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnClearVisitorScore { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton clearHomeScoreButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIStepper foulStepper { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField homeScore { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIStepper homeScoreStepper { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIStepper outStepper { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIStepper strikesStepper { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtBalls { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtFouls { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtHome { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtOuts { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtStrikes { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtVisitor { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField vistorScore { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIStepper vistorScoreStepper { get; set; }

        [Action ("ballsStepperChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ballsStepperChanged (UIKit.UIStepper sender);

        [Action ("clearVisitorClicked:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void clearVisitorClicked (UIKit.UIButton sender);

        [Action ("foulStepperValueChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void foulStepperValueChanged (UIKit.UIStepper sender);

        [Action ("homeScoreValueChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void homeScoreValueChanged (UIKit.UIStepper sender);

        [Action ("outStepperChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void outStepperChanged (UIKit.UIStepper sender);

        [Action ("resetHomeScoreClicked:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void resetHomeScoreClicked (UIKit.UIButton sender);

        [Action ("strikesStepperValueChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void strikesStepperValueChanged (UIKit.UIStepper sender);

        [Action ("visitorScoreStepperStep:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void visitorScoreStepperStep (UIKit.UIStepper sender);

        void ReleaseDesignerOutlets ()
        {
            if (ballsStepper != null) {
                ballsStepper.Dispose ();
                ballsStepper = null;
            }

            if (btnClearVisitorScore != null) {
                btnClearVisitorScore.Dispose ();
                btnClearVisitorScore = null;
            }

            if (clearHomeScoreButton != null) {
                clearHomeScoreButton.Dispose ();
                clearHomeScoreButton = null;
            }

            if (foulStepper != null) {
                foulStepper.Dispose ();
                foulStepper = null;
            }

            if (homeScore != null) {
                homeScore.Dispose ();
                homeScore = null;
            }

            if (homeScoreStepper != null) {
                homeScoreStepper.Dispose ();
                homeScoreStepper = null;
            }

            if (outStepper != null) {
                outStepper.Dispose ();
                outStepper = null;
            }

            if (strikesStepper != null) {
                strikesStepper.Dispose ();
                strikesStepper = null;
            }

            if (txtBalls != null) {
                txtBalls.Dispose ();
                txtBalls = null;
            }

            if (txtFouls != null) {
                txtFouls.Dispose ();
                txtFouls = null;
            }

            if (txtHome != null) {
                txtHome.Dispose ();
                txtHome = null;
            }

            if (txtOuts != null) {
                txtOuts.Dispose ();
                txtOuts = null;
            }

            if (txtStrikes != null) {
                txtStrikes.Dispose ();
                txtStrikes = null;
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