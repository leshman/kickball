using System;

using UIKit;

namespace KickballScoreKeeper
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            this.vistorScoreStepper.Value = 0;
            this.homeScoreStepper.Value = 0;
            this.homeScore.Text = "0";
            this.vistorScore.Text = "0";

            this.UpdateTextValue(0, this.txtFouls);
            this.UpdateTextValue(0, this.txtBalls);
            this.UpdateTextValue(0, this.txtStrikes);
            this.UpdateTextValue(0, this.txtOuts);

            this.txtVisitor.ShouldReturn += (textField) => {
                textField.ResignFirstResponder();
                return true;
            };

            this.txtHome.ShouldReturn += (textField) => {
                textField.ResignFirstResponder();
                return true;
            };

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        private void showClearVisitorAlert()
        {
            var answer = UIAlertController.Create("Clear Visitor Score?", "Would you like to clear the Visitor Score?", UIAlertControllerStyle.Alert);
            answer.AddAction(UIAlertAction.Create("No", UIAlertActionStyle.Cancel, null));
            answer.AddAction(UIAlertAction.Create("Yes", UIAlertActionStyle.Destructive, action => resetScore(this.vistorScoreStepper, this.vistorScore)));

            this.PresentViewController(answer, true, null);
        }

        private void showClearHomeAlert()
        {
            var answer = UIAlertController.Create("Clear Home Score?", "Would you like to clear the Home Score?", UIAlertControllerStyle.Alert);
            answer.AddAction(UIAlertAction.Create("No", UIAlertActionStyle.Cancel, null));
            answer.AddAction(UIAlertAction.Create("Yes", UIAlertActionStyle.Destructive, action => resetScore(this.homeScoreStepper, this.homeScore)));

            this.PresentViewController(answer, true, null);
        }

        partial void resetHomeScoreClicked(UIButton sender)
        {
            this.showClearHomeAlert();
        }

        partial void visitorScoreStepperStep(UIStepper sender)
        {
            this.vistorScore.Text = this.vistorScoreStepper.Value.ToString();
        }

        partial void clearVisitorClicked(UIButton sender)
        {
            this.showClearVisitorAlert();
        }

        private void resetScore(UIStepper field, UITextField textField)
        {
            field.Value = 0;
            textField.Text = "0";

        }

        partial void homeScoreValueChanged(UIStepper sender)
        {
            this.homeScore.Text = this.homeScoreStepper.Value.ToString();
        }

        partial void ballsStepperChanged(UIStepper sender)
        {
            this.UpdateTextValue(sender.Value, this.txtBalls);
        }

        private void UpdateTextValue(Double value, UITextField field)
        {
            field.Text = value.ToString();
        }

        partial void strikesStepperValueChanged(UIStepper sender)
        {
            this.UpdateTextValue(sender.Value, this.txtStrikes);
        }

        partial void foulStepperValueChanged(UIStepper sender)
        {
            this.UpdateTextValue(sender.Value, this.txtFouls);
        }

        partial void outStepperChanged(UIStepper sender)
        {
            this.UpdateTextValue(sender.Value, this.txtOuts);
        }
    }
}
