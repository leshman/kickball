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
            this.vistorScore.Text = "0";
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
            answer.AddAction(UIAlertAction.Create("Yes", UIAlertActionStyle.Destructive, action => clearVistorScore()));

            this.PresentViewController(answer, true, null);
        }

        partial void vistorScoreChange(UIStepper sender)
        {
            this.vistorScore.Text = (Convert.ToInt64(this.vistorScore.Text) + 1).ToString();
        }

        partial void clearVisitorClicked(UIButton sender)
        {
            this.showClearVisitorAlert();
        }

        private void clearVistorScore()
        {
            this.vistorScore.Text = "0";
        }
    }
}
