using System;

namespace Cal
{
    // 구조체로 바꿔서 사용해보기 위해 변수 무더기를 가져와서 구조체로 따로 생성
    struct Operation_items
    {
        public string operand1; // 첫 번째 피연산자
        public string operand2; // 두 번째 피연산자
        public char operation; // 현재 선택된 연산자
        public double result; // 계산 결과
        public bool isEqualsPressed; // '=' 버튼이 눌렸는지 여부
    }

    public class Calculator
    {
        Operation_items operation1;
        

        public string CurrentInput { get; private set; } = string.Empty; // 현재 입력 중인 숫자
        public string CalculationDisplay { get; private set; } = string.Empty; // 계산 내역 표시용 문자열
        


        public bool CanCalculate => !operation1.isEqualsPressed; // 계산 가능 여부를 반환
        
        public Calculator()
        {
            operation1.operand1 = string.Empty; // 첫 번째 피연산자
            operation1.operand2 = string.Empty; // 두 번째 피연산자
        }
        
        public void Backspace()
        {
            if (!string.IsNullOrEmpty(CurrentInput))
            {
                // 입력된 값에서 마지막 문자를 제거
                CurrentInput = CurrentInput.Substring(0, CurrentInput.Length - 1);
            }
        }

        // 숫자 추가 메서드
        public void AppendDigit(string digit)
        {
            // '=' 버튼을 눌렀다면 입력 초기화
            if (operation1.isEqualsPressed)
            {
                ClearEntry();
                CalculationDisplay = string.Empty;
                operation1.isEqualsPressed = false;
            }

            // 소수점 입력 처리: 현재 입력에 소수점이 있으면 추가하지 않음
            if (digit == "." && CurrentInput.Contains("."))
                return;

            CurrentInput += digit; // 입력에 숫자나 소수점 추가
        }

        public void CalculatePercentage()
        {
            if (string.IsNullOrEmpty(CurrentInput) || string.IsNullOrEmpty(operation1.operand1))
                return; // 입력값이 없으면 실행하지 않음

            double num1, num2;
            double.TryParse(operation1.operand1, out num1); // 첫 번째 피연산자 변환
            double.TryParse(CurrentInput, out num2); // 현재 입력 값 변환

            switch (operation1.operation)
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

            operation1.isEqualsPressed = false; // 다음 입력에 영향을 주지 않도록 초기화
        }




        // 연산자 설정 메서드
        public void SetOperation(char op)
        {
            if (!string.IsNullOrEmpty(CurrentInput))
            {
                operation1.operand1 = CurrentInput; // 첫 번째 피연산자 저장
                operation1.operation = op; // 연산자 저장
                CalculationDisplay = operation1.operand1 + " " + operation1.operation; // 표시용 문자열 업데이트
                CurrentInput = string.Empty; // 현재 입력 초기화
                operation1.isEqualsPressed = false;
            }
        }

        // 계산 실행 메서드
        public void Calculate()
        {
            if (string.IsNullOrEmpty(CurrentInput) || string.IsNullOrEmpty(operation1.operand1))
                return; // 입력이 부족하면 계산하지 않음

            operation1.operand2 = CurrentInput; // 두 번째 피연산자 저장
            double num1, num2;
            double.TryParse(operation1.operand1, out num1); // 첫 번째 피연산자 파싱
            double.TryParse(operation1.operand2, out num2); // 두 번째 피연산자 파싱

            // 연산자에 따른 계산 수행
            switch (operation1.operation)
            {
                case '+':
                    operation1.result = num1 + num2;
                    break;
                case '-':
                    operation1.result = num1 - num2;
                    break;
                case '*':
                    operation1.result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                        operation1.result = num1 / num2;
                    else
                        throw new InvalidOperationException("0으로 나눌 수 없습니다."); // 나눗셈 예외 처리
                    break;
            }

            // 계산 결과와 내역 업데이트
            CalculationDisplay = operation1.operand1 + " " + operation1.operation + " " + operation1.operand2 + " = " + operation1.result;
            CurrentInput = operation1.result.ToString(); // 결과를 입력으로 설정
            operation1.isEqualsPressed = true; // '=' 버튼 누름 상태로 변경
        }

        // 모든 데이터 초기화
        public void ClearAll()
        {
            CurrentInput = string.Empty;
            operation1.operand1 = string.Empty;
            operation1.operand2 = string.Empty;
            CalculationDisplay = string.Empty;
            operation1.result = 0;
            operation1.isEqualsPressed = false;
        }

        // 현재 입력 초기화
        public void ClearEntry()
        {
            CurrentInput = string.Empty;
        }
    }
}
