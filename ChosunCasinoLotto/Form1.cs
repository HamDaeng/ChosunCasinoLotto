using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChosunCasinoLotto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Font = new Font(FontLibrary.Families[0], 12);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            string userName = userNameTextBox.Text.Trim();
            string lottoRoundText = lottoRoundTextBox.Text.Trim();
            int lottoRound;

            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("사용자 이름을 입력해주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(lottoRoundText, out lottoRound) || lottoRound <= 0)
            {
                MessageBox.Show("유효한 로또 회차를 입력해주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lottoNumbersListBox.Items.Clear();
            string[] allLottoNumbers = new string[5];

            var lottoNumbers = GenerateLottoNumbers();

            for (int i = 0; i < 5; i++) // 5줄 생성
            {
                string numbers = string.Join(" ", lottoNumbers[i]);
                lottoNumbersListBox.Items.Add(numbers);
                allLottoNumbers[i] = numbers;
            }

            userNameTextBox.Text = "";

            SaveLottoNumbersToFile(userName, lottoRound, allLottoNumbers);
        }

        private int[][] GenerateLottoNumbers()
        {
            Random rand = new Random();
            int[][] numbers = new int[5][];
            for (int i = 0; i < 5; i++)
            {
                numbers[i] = new int[6];

                for (int j = 0; j < 6; j++)
                {
                    int num;
                    do
                    {
                        num = rand.Next(1, 46); // 로또 번호는 1부터 45까지
                    } while (numbers[i].Contains(num));
                    numbers[i][j] = num;
                }
                //Array.Sort(numbers);
            }

            return numbers;
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            if (lottoNumbersListBox.Items.Count > 0)
            {
                string copiedText = string.Join(Environment.NewLine, lottoNumbersListBox.Items.Cast<string>());
                Clipboard.SetText(copiedText);
                MessageBox.Show("복사되었습니다!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("생성된 번호가 없습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SaveLottoNumbersToFile(string userName, int lottoRound, string[] lottoNumbers)
        {
            string directoryPath = @"C:\조선노름판_로또번호"; // 원하는 디렉토리 경로로 설정
            Directory.CreateDirectory(directoryPath);

            string filePath = Path.Combine(directoryPath, $"{lottoRound}회차.txt");
            using (StreamWriter writer = new StreamWriter(filePath, true)) // true는 기존 파일에 덧붙이기
            {
                writer.WriteLine($"로또 구매자 닉네임");
                writer.WriteLine(userName);
                foreach (string numbers in lottoNumbers)
                {
                    writer.WriteLine(numbers);
                }
                writer.WriteLine(); // 줄바꿈 추가
            }
        }
    }
}
