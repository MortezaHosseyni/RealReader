using System.IO.Ports;

namespace RealReader
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadPorts();
        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            var serialPort = new SerialPort
            {
                PortName = cmb_Ports.Text,
                BaudRate = int.Parse(txt_BaudRate.Text),
                DataBits = int.Parse(txt_Bits.Text),
                Parity = Parity.None,
                StopBits = StopBits.One,
                Handshake = Handshake.None
            };

            serialPort.DataReceived += SerialPort_DataReceived;

            var time = $"[{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}]";

            try
            {
                serialPort.Open();


                rtb_Logs.Text += $"{time} Serial port opened. Listening for data...\n";

                rtb_Logs.Text += $"{time} Press any key to close...\n";
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                rtb_Logs.Text += $"{time} Error: {ex.Message}\n";
            }
            finally
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                    rtb_Logs.Text += $"{time} Serial port closed.\n";
                }
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var sp = (SerialPort)sender;
            var data = sp.ReadExisting();

            var time = $"[{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}]";

            rtb_Logs.Text += $"{time} Data received: {data}\n";
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            rtb_Logs.Clear();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            using var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog.Title = "Save RichTextBox Content";

            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
            try
            {
                File.WriteAllText(saveFileDialog.FileName, rtb_Logs.Text);
                MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ReloadPorts_Click(object sender, EventArgs e)
        {
            LoadPorts();
        }

        private void LoadPorts()
        {
            var time = $"[{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}]";
            cmb_Ports.Items.Clear();

            try
            {
                string[] portNames = SerialPort.GetPortNames();

                if (portNames.Length > 0)
                {
                    foreach (var port in portNames)
                    {
                        cmb_Ports.Items.Add(port);
                    }
                }
                else
                {
                    rtb_Logs.Text += $"{time} No serial ports found on this system.";
                }
            }
            catch (Exception ex)
            {
                rtb_Logs.Text += $"{time} Error: {ex.Message}";
            }
        }
    }
}
