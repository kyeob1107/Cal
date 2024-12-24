using System;

namespace Cal
{
    public class Calculator
    {
        public string CurrentInput { get; private set; } = string.Empty; // 현재 입력 중인 숫자
        public string CalculationDisplay { get; private set; } = string.Empty; // 계산 내역 표시용 문자열
        private string operand1 = string.Empty; // 첫 번째 피연산자
        private string operand2 = string.Empty; // 두 번째 피연산자
        private char operation; // 현재 선택된 연산자
        private double result; // 계산 결과
        private bool isEqualsPressed; // '=' 버튼이 눌렸는지 여부

        public bool CanCalculate => !isEqualsPressed; // 계산 가능 여부를 반환

        // 숫자 추가 메서드
        public void AppendDigit(string digit)
        {
            // '=' 버튼을 눌렀다면 입력 초기화
            if (isEqualsPressed)
            {
                ClearEntry();
                CalculationDisplay = string.Empty;
                isEqualsPressed = false;
            }

            // 소수점 입력 처리: 현재 입력에 소수점이 있으면 추가하지 않음
            if (digit == "." && CurrentInput.Contains("."))
                return;

            CurrentInput += digit; // 입력에 숫자나 소수점 추가
        }

        public void CalculatePercentage()
        {
            if (string.IsNullOrEmpty(CurrentInput) || string.IsNullOrEmpty(operand1))
                return; // 입력값이 없으면 실행하지 않음

            double num1, num2;
            double.TryParse(operand1, out num1); // 첫 번째 피연산자 변환
            double.TryParse(CurrentInput, out num2); // 현재 입력 값 변환

            switch (operation)
            {
                case '+':
                case '-':
                    // 덧셈/뺄셈: 기준값(num1)의 백분율(num2)을 계산
                    CurrentInput = (num1 * (num2 / 100)).ToString();
                    break;

                case '*':
                    // 곱셈: 기준값(num1) * (입력값의 백분율)
                    CurrentInput = (num1 * (num2 / 100)).ToString();
                    break;

                case '/':
                    // 나눗셈: 기준값(num1)을 입력값의 백분율로 나눔
                    if (num2 != 0)
                        CurrentInput = (num1 / (num2 / 100)).ToString();
                    break;
            }

            isEqualsPressed = false; // 다음 입력에 영향을 주지 않도록 초기화
        }




        // 연산자 설정 메서드
        public void SetOperation(char op)
        {
            if (!string.IsNullOrEmpty(CurrentInput))
            {
                operand1 = CurrentInput; // 첫 번째 피연산자 저장
                operation = op; // 연산자 저장
                CalculationDisplay = operand1 + " " + operation; // 표시용 문자열 업데이트
                CurrentInput = string.Empty; // 현재 입력 초기화
                isEqualsPressed = false;
            }
        }

        // 계산 실행 메서드
        public void Calculate()
        {
            if (string.IsNullOrEmpty(CurrentInput) || string.IsNullOrEmpty(operand1))
                return; // 입력이 부족하면 계산하지 않음

            operand2 = CurrentInput; // 두 번째 피연산자 저장
            double num1, num2;
            double.TryParse(operand1, out num1); // 첫 번째 피연산자 파싱
            double.TryParse(operand2, out num2); // 두 번째 피연산자 파싱

            // 연산자에 따른 계산 수행
            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        throw new InvalidOperationException("0으로 나눌 수 없습니다."); // 나눗셈 예외 처리
                    break;
            }

            // 계산 결과와 내역 업데이트
            CalculationDisplay = operand1 + " " + operation + " " + operand2 + " = " + result;
            CurrentInput = result.ToString(); // 결과를 입력으로 설정
            isEqualsPressed = true; // '=' 버튼 누름 상태로 변경
        }

        // 모든 데이터 초기화
        public void ClearAll()
        {
            CurrentInput = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
            CalculationDisplay = string.Empty;
            result = 0;
            isEqualsPressed = false;
        }

        // 현재 입력 초기화
        public void ClearEntry()
        {
            CurrentInput = string.Empty;
        }
    }
}
