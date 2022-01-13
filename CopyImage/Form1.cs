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
                // 오픈파일 다이알로그라는 클래스에 dialog 변수를 선언해서
                // OpenFileDialog() 함수를 지정해준다

                if (dialog.ShowDialog() == DialogResult.OK)
                    // dialog결과가 쇼다이아로그함수랑 같다면
                {
                    pictureBox1.ImageLocation = dialog.FileName.ToString();
                    // 피쳐박스1의 이미지 로케이션에 dialog.filename을 넣어준다
                    string path = Path.Combine(@"~\image\");
                    // 넣은 path는 image\이다
                    if (!Directory.Exists(path))
                        // 만약 디렉토리가 패스에 존재하지 않는다면
                    {
                        Directory.CreateDirectory(path);
                        // 디렉토리클래스에서 path에 파일을 생성해라
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