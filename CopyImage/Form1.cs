namespace CopyImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                // �������� ���̾˷α׶�� Ŭ������ dialog ������ �����ؼ�
                // OpenFileDialog() �Լ��� �������ش�

                if (dialog.ShowDialog() == DialogResult.OK)
                    // dialog����� ����̾Ʒα��Լ��� ���ٸ�
                {
                    pictureBox1.ImageLocation = dialog.FileName.ToString();
                    // ���Ĺڽ�1�� �̹��� �����̼ǿ� dialog.filename�� �־��ش�
                    string path = Path.Combine(@"~\image\");
                    // ���� path�� image\�̴�
                    if (!Directory.Exists(path))
                        // ���� ���丮�� �н��� �������� �ʴ´ٸ�
                    {
                        Directory.CreateDirectory(path);
                        // ���丮Ŭ�������� path�� ������ �����ض�
                    }
                    var fileName = System.IO.Path.GetFileName(dialog.FileName);
                    path = path + fileName;
                    File.Copy(dialog.FileName, path);
                }

           
            }
            catch (Exception ex) { }
        }
    }
}