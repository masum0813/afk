using System.ComponentModel;
using AFK.Mouse;

namespace AFK
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {
            int pos = ((TextBox)sender).SelectionStart;
            var textBox = sender as TextBox;
            int actualVal;
            int retVal;
            if (textBox is not null)
            {
                if (int.TryParse(textBox.Text.Trim(), out retVal))
                {
                    actualVal = Convert.ToInt32(textBox.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Sadece rakam girebilirsiniz!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (textBox.Text.Length > 0)
                    {
                        textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
                    }
                    else
                    {
                        textBox.Text = "0";
                    }

                    ((TextBox)sender).SelectionStart = pos;

                }

            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            #region cmbBoxMouseButton fill
            var bindListMouseButton = new BindingList<KeyValuePair<string, string>>();

            bindListMouseButton.Add(new KeyValuePair<string, string>("0", "Left"));
            bindListMouseButton.Add(new KeyValuePair<string, string>("1", "Right"));
            bindListMouseButton.Add(new KeyValuePair<string, string>("2", "Middle"));



            cmbBoxMouseButton.DataSource = bindListMouseButton;
            cmbBoxMouseButton.ValueMember = "Key";
            cmbBoxMouseButton.DisplayMember = "Value";
            cmbBoxMouseButton.SelectedIndex = 0;
            #endregion

            #region cmbBoxMouseButton fill
            var bindListClickType = new BindingList<KeyValuePair<string, string>>();

            bindListClickType.Add(new KeyValuePair<string, string>("0", "Single"));
            bindListClickType.Add(new KeyValuePair<string, string>("1", "Double"));


            cmbBoxClickType.DataSource = bindListClickType;
            cmbBoxClickType.ValueMember = "Key";
            cmbBoxClickType.DisplayMember = "Value";
            cmbBoxClickType.SelectedIndex = 0;
            #endregion

            #region radioButton fill
            radioBtnRepeatCount.Checked = true;
            radioBtnRepeatForever.Checked = false;
            #endregion

            this.KeyUp += new System.Windows.Forms.KeyEventHandler(KeyEvent);
            this.KeyPreview = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            //run();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {



        }

        private async void KeyEvent(object sender, KeyEventArgs e) //Keyup Event 
        {
            if (e.KeyCode == Keys.F8)
            {
                using (var cancellationTokenSource = new CancellationTokenSource())
                {
                    
                    if (btnStart.Enabled)
                    {
                        btnStart.Enabled = false;
                        btnStop.Enabled = true;
                        
                        try
                        {
                            await Task.Run(() => run(cancellationTokenSource.Token));
                            //await Task.Run(() => run());
                        }
                        catch (TaskCanceledException)
                        {
                            MessageBox.Show("Task was cancelled","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        btnStart.Enabled = true;
                        btnStop.Enabled = false;
                    }
                    else
                    {
                        btnStart.Enabled = true;
                        btnStop.Enabled = false;
                        //await Task.Run(() => run());
                        //run();


                        var cancelledTask = Task.Run(() =>
                        {
                            // Cancel the task
                            cancellationTokenSource.Cancel();
                        });

                        await cancelledTask;
                    }

                }

            }

        }

        private void run()
        {

            int valMS = 0;
            valMS = (Convert.ToInt32(txtHour.Text.Trim()) * 60 * 60 * 1000)
                    + (Convert.ToInt32(txtMinute.Text.Trim()) * 60 * 1000)
                    + (Convert.ToInt32(txtSecond.Text.Trim()) * 1000)
                    + Convert.ToInt32(txtMiliSecond.Text.Trim());

            Thread.Sleep(valMS);
        }

        private void run(CancellationToken cancellationToken)
        {
            int clickCount = (int)nmrcUpDownRepeatCount.Value;
            Mouse.MouseOperations mouseEvent = new Mouse.MouseOperations();
            int X = Cursor.Position.X;
            int Y = Cursor.Position.Y;

            int valMS = 0;
            valMS = (Convert.ToInt32(txtHour.Text.Trim()) * 60 * 60 * 1000)
                    + (Convert.ToInt32(txtMinute.Text.Trim()) * 60 * 1000)
                    + (Convert.ToInt32(txtSecond.Text.Trim()) * 1000)
                    + Convert.ToInt32(txtMiliSecond.Text.Trim());

            for (int i = 0; i < clickCount; i++)
            {
                mouseEvent.ClickMouseLeftButton(new Point(X, Y));
                Thread.Sleep(valMS);
                // Check if a cancellation is requested, if yes,
                // throw a TaskCanceledException.
                //if (cancellationToken.IsCancellationRequested)
                //    throw new TaskCanceledException(task);

                //cancellationToken.ThrowIfCancellationRequested();
            }



        }
    }
}