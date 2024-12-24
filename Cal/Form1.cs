using System;
using System.Windows.Forms;

namespace Cal
{
    public partial class Form1 : Form
    {
        private Calculator calculator; // 계산 로직을 처리할 Calculator 인스턴스
        private Advance advance; // 추가적인 계산 로직 처리할 Advance 인스턴스

        public Form1()
        {
            InitializeComponent();
            calculator = new Calculator(); // Calculator 초기화
            advance = new Advance(); // Advance 초기화
            AssignButtonEvents(); // 버튼 이벤트 할당
        }

        // 버튼 이벤트를 할당하는 메서드
        private void AssignButtonEvents()
        {
            digitButton0.Click += DigitButton_Click;
            digitButton1.Click += DigitButton_Click;
            digitButton2.Click += DigitButton_Click;
            digitButton3.Click += DigitButton_Click;
            digitButton4.Click += DigitButton_Click;
            digitButton5.Click += DigitButton_Click;
            digitButton6.Click += DigitButton_Click;
            digitButton7.Click += DigitButton_Click; 
            digitButton8.Click += DigitButton_Click;
            digitButton9.Click += DigitButton_Click;

            decimalPointButton.Click += DigitButton_Click;

            addButton.Click += OperationButton_Click;
            subtractButton.Click += OperationButton_Click;
            multiplyButton.Click += OperationButton_Click;
            divideButton.Click += OperationButton_Click;

            equalsButton.Click += EqualsButton_Click;
            clearButton.Click += ClearButton_Click;
            clearEntryButton.Click += ClearEntryButton_Click;

        }


        // 숫자 버튼 클릭 이벤트 처리
        private void DigitButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            calculator.AppendDigit(button.Text); // 버튼의 텍스트(숫자)를 Calculator에 전달
            UpdateDisplay(); // 디스플레이 업데이트
        }

        // 연산자 버튼 클릭 이벤트 처리
        private void OperationButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            calculator.SetOperation(button.Text[0]); // 버튼의 텍스트(연산자)를 Calculator에 전달
            UpdateDisplay(); // 디스플레이 업데이트
        }

        // '=' 버튼 클릭 이벤트 처리
        private void EqualsButton_Click(object sender, EventArgs e)
        {
            if (!calculator.CanCalculate)
                return; // 계산 가능 여부 확인

            calculator.Calculate(); // 계산 수행
            UpdateDisplay(); // 디스플레이 업데이트
        }

        // 전체 지우기 버튼 클릭 이벤트 처리
        private void ClearButton_Click(object sender, EventArgs e)
        {
            calculator.ClearAll(); // 모든 데이터 초기화
            UpdateDisplay(); // 디스플레이 업데이트
        }

        // 입력 지우기 버튼 클릭 이벤트 처리
        private void ClearEntryButton_Click(object sender, EventArgs e)
        {
            calculator.ClearEntry(); // 현재 입력 초기화
            UpdateDisplay(); // 디스플레이 업데이트
        }



        // 디스플레이를 업데이트하는 메서드
        private void UpdateDisplay()
        {
            textboxResult.Text = calculator.CurrentInput; // 현재 입력 표시
            textBoxCalculation.Text = calculator.CalculationDisplay; // 계산 내역 표시
        }

        
        private void textBoxCalculation_TextChanged(object sender, EventArgs e)
        {
        }

        private void percentButton_Click(object sender, EventArgs e)
        {
            calculator.CalculatePercentage(); // 백분율 계산
            UpdateDisplay(); // 디스플레이 업데이트
        }

        private void backspaceButton_Click(object sender, EventArgs e)
        {
            calculator.Backspace(); // Calculator의 Backspace 메서드 호출
            UpdateDisplay(); // 디스플레이 업데이트
        }
    }
}
