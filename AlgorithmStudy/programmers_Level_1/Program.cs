using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        //RectangleStar.solution(5,4);
    }

    // 직사각형 별찍기
    public class RectangleStar
    {
        public static void solution(int n, int m)
        {
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }

    // x만큼 간격이 있는 n개의 숫자
    public class XWithNNumber
    {
        public static long[] Solution(int x, int n)
        {
            long[] answer = new long[n];

            for (int i = 1; i <= n; ++i)
            {
                answer[i - 1] = (long)x * i;
            }

            return answer;
        }
    }

    // 행렬의 덧셈
    public class ProcessionPlus
    {
        public static int[,] solution(int[,] arr1, int[,] arr2)
        {
            int[,] answer = new int[arr1.GetLength(0), arr1.GetLength(1)];

            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    answer[i, j] = arr1[i, j] + arr2[i, j];
                }
            }


            return answer;
        }
    }

    // 핸드폰 번호 가리기
    public class PhoneNumberHide
    {
        public static string solution(string phone_number)
        {
            string answer = "";

            for (int i = 0; i < phone_number.Length - 4; ++i)
                answer += "*";

            answer += phone_number.Substring(phone_number.Length - 4, 4);

            return answer;
        }
    }

    // 하샤드 수
    public class HashadNumber
    {
        public static bool solution(int x)
        {
            string str = x.ToString();
            int total = 0;

            for (int i = 0; i < str.Length; ++i)
                total += int.Parse(str[i].ToString());

            if (x % total != 0)
                return false;

            return true;
        }
    }

    // 평균 구하기
    public class AverageNumber
    {
        public double solution(int[] arr)
        {
            double answer = 0;

            for (int i = 0; i < arr.Length; ++i)
                answer += arr[i];

            return answer / arr.Length;
        }
    }

    // 콜라츠 추측
    public class ColatzGuessing
    {
        public int solution(int num)
        {
            long answer = (long)num;
            int count = 0;

            if (answer == 1)
                return 0;

            while (true)
            {
                if (answer == 1)
                {
                    break;
                }

                if (answer % 2 == 0)
                {
                    answer /= 2;
                }
                else
                {
                    answer *= 3;
                    answer += 1;
                }

                count++;

                if (count >= 500)
                    return -1;
            }

            return count;
        }
    }

    // 최대 공약수와 최소공배수
    public class MinOrMaxNumber
    {
        public int[] solution(int n, int m)
        {
            int[] answer = new int[2];
            int min = 0;
            int max = 0;

            min = GCD(n, m);

            max = (n * m) / min;

            answer[0] = min;
            answer[1] = max;

            return answer;
        }

        public int GCD(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return GCD(b, a % b);
        }
    }

    // 짝수와 홀수
    public class OddOrEvenNumber
    {
        public string solution(int num)
        {
            return num % 2 == 0 ? "Even" : "Odd";
        }
    }

    // 제일 작은 수 제거하기
    public class VeryMinNumberDelete
    {
        public int[] solution(int[] arr)
        {
            int[] answer = new int[arr.Length - 1];
            int min = 0;

            if (arr.Length == 1)
            {
                int[] num = new int[] { -1 };
                return num;
            }

            int index = 0;
            min = arr[0];
            for (int i = 1; i < arr.Length; ++i)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    index = i;
                }
            }

            List<int> arrList = new List<int>(arr);

            arrList.RemoveAt(index);

            return arrList.ToArray();
        }
    }

    // 정수 제곱근 판별
    public class SquareRootCheck
    {
        public static long solution(long n)
        {
            long answer = 0;

            answer = (long)Math.Sqrt(n);

            return (answer * answer == n) ? (answer + 1) * (answer + 1) : -1;
        }
    }

    // 정수 내림차순으로 배치하기
    public class DescendingSort
    {
        public long solution(long n)
        {
            char[] ch = n.ToString().ToCharArray();

            Array.Sort(ch);
            Array.Reverse(ch);

            long answer = long.Parse(new string(ch));

            return answer;
        }
    }

    // 자연수 뒤집어 배열로 만들기
    public class NaturalNumberReverseArray
    {
        public int[] solution(long n)
        {
            int[] answer = new int[n.ToString().Length];
            char[] ch = n.ToString().ToCharArray();

            Array.Reverse(ch);

            string str = new string(ch);

            for (int i = 0; i < answer.Length; ++i)
                answer[i] = int.Parse(str[i].ToString());

            return answer;
        }
    }

    // 자릿수 더하기
    public class DigitSumNumber
    {
        public int solution(int n)
        {
            char[] ch = n.ToString().ToCharArray();

            int answer = 0;

            for (int i = 0; i < ch.Length; ++i)
                answer += int.Parse(ch[i].ToString());

            return answer;
        }
    }

    // 이상한 문자 만들기
    public class CreateWeirdCharacters
    {
        public string solution(string s)
        {
            string answer = "";
            string[] str = s.Split(' ');

            for (int i = 0; i < str.Length; ++i)
            {
                for (int j = 0; j < str[i].Length; ++j)
                {
                    if (j % 2 == 0)
                    {
                        answer += str[i][j].ToString().ToUpper();
                    }
                    else
                    {
                        answer += str[i][j].ToString().ToLower();
                    }
                }
                if (i != str.Length - 1)
                    answer += " ";
            }

            return answer;
        }
    }

    // 약수의 합
    public class SumOfFactors
    {
        public int solution(int n)
        {
            int answer = 0;

            if (n == 0)
                return 0;
            if (n == 1)
                return 1;

            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0)
                    answer += i;
            }

            return answer + 1;
        }
    }

    // 시저 암호
    public class CaesarCipher
    {
        public static string solution(string s, int n)
        {
            string answer = "";

            char[] ch = s.ToCharArray();

            for (int i = 0; i < ch.Length; ++i)
            {
                int num = Convert.ToInt32(ch[i]);

                if (num == 32)
                {
                    answer += " ";
                    continue;
                }

                if (num >= 97 && num <= 122)
                {
                    num += n;
                    if (num > 122)
                        num = 96 + (num - 122);
                }
                else if (num >= 65 && num <= 90)
                {
                    num += n;
                    if (num > 90)
                        num = 64 + (num - 90);
                }

                answer += Convert.ToChar(num);
            }

            return answer;
        }
    }

    // 문자열을 정수로 바꾸기
    public class CharactersChangeDescending
    {
        public int solution(string s)
        {
            int answer = int.Parse(s);
            return answer;
        }
    }

    // 수박수박수박수박수박수?
    public class SooBacSooBacSoo
    {
        public string solution(int n)
        {
            StringBuilder str = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                    str.Append("수");
                else
                    str.Append("박");
            }
            return str.ToString();
        }
    }

    // 소수 찾기
    public class FindDecimals1
    {
        // 에라토스테네스의 체

        public int solution(int n)
        {
            int answer = 0;

            for (int i = 2; i <= n; i++)
            {
                bool check = false;

                for (int a = 2; a * a <= i; a++)
                {
                    if (i % a == 0)
                    {
                        check = true;
                        break;
                    }
                }

                if (!check)
                    answer++;
            }

            return answer;
        }
    }

    // 서울에서 김서방 찾기
    public class KimAndSeoulSearch
    {
        public string solution(string[] seoul)
        {
            string answer = "";
            for (int i = 0; i < seoul.Length; ++i)
            {
                if (seoul[i] == "Kim")
                {
                    answer = string.Format("김서방은 {0}에 있다", i);
                    break;
                }
            }

            return answer;
        }
    }

    // 문자열 다루기 기본
    public class CharactersBasicDealWith
    {
        public static bool solution(string s)
        {
            if (s.Length != 4 && s.Length != 6)
                return false;

            for (int i = 0; i < s.Length; ++i)
            {
                int num = Convert.ToInt32(s[i]);

                if (num >= 58)
                    return false;
            }

            return true;
        }
    }

    // 문자열 내림차순으로 배치하기
    public class TextDescendingSort
    {
        public static string solution(string s)
        {
            char[] ch = s.ToCharArray();

            Array.Sort(ch);
            Array.Reverse(ch);

            string answer = new string(ch);

            return answer;
        }
    }

    // 문자열 내 마음대로 정렬하기
    public class TextMyMindSort
    {
        public static string[] solution(string[] strings, int n)
        {
            string[] str = new string[strings.Length];

            // 문자열앞에 순서를 붙임
            for (int i = 0; i < strings.Length; ++i)
            {
                strings[i] = strings[i].Substring(n, 1) + strings[i];
            }

            Array.Sort(strings);

            // 붙인거 잘라냄 
            for (int i = 0; i < strings.Length; ++i)
                strings[i] = strings[i].Substring(1);

            str = strings;

            return str;
        }
    }

    // 두 정수 사이의 합
    public class TwoNumberSum
    {
        public static long solution(int a, int b)
        {
            long answer = 0;

            if (a > b)
            {
                for (int i = b; i <= a; i++)
                    answer += i;
            }
            else
            {
                for (int i = a; i <= b; i++)
                    answer += i;
            }

            return answer;
        }
    }

    // 나누어 떨어지는 숫자 배열
    public class DivisibleArrayOfNumbers
    {
        public static int[] solution(int[] arr, int divisor)
        {
            List<int> data = new List<int>();

            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] % divisor == 0)
                    data.Add(arr[i]);
            }

            if (data.Count > 0)
                data.Sort();
            else
                data.Add(-1);

            int[] answer = data.ToArray();

            return answer;
        }
    }

    // 가운데 글자 가져오기
    public class GetMiddleLetter
    {
        public static string solution(string s)
        {
            int index = 0;

            if (s.Length % 2 == 0)
            {
                index = s.Length / 2 - 1;
                s = s.Substring(index, 2);
            }
            else
            {
                index = s.Length / 2;
                s = s.Substring(index, 1);
            }

            return s;
        }
    }

    // 부족한 금액 계산하기
    public class CalculateTheShortfall
    {
        public long solution(int price, int money, int count)
        {
            long sum = 0;
            long answer = 0;

            for (int i = 1; i <= count; i++)
            {
                sum += (long)price * i;
            }

            answer = sum - money;

            return answer <= 0 ? 0 : answer;
        }
    }

    // 나머지가 1이 되는 수 찾기
    public class FindNumberRemainderOne
    {
        public int solution(int n)
        {
            int answer = 0;
            int num = 0;

            for (int i = 2; i < n - 1; ++i)
            {
                if ((n - 1) % i == 0)
                {
                    num = i;
                    break;
                }
            }

            if (num == 0)
                answer = n - 1;
            else
                answer = num;

            return answer;
        }
    }

    // 2016년
    public class Year2016
    {
        public string solution(int a, int b)
        {
            DateTime now = new DateTime(2016, a, b);

            string answer = now.DayOfWeek.ToString();

            answer = answer.Substring(0, 3).ToUpper();
            return answer;
        }
    }

    // 두 개 뽑아서 더하기
    public class TwoChoicePlus
    {
        public int[] solution(int[] numbers)
        {
            int[] answer;
            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (!result.Contains(numbers[i] + numbers[j]))
                        result.Add(numbers[i] + numbers[j]);
                }
            }

            result.Sort();

            answer = new int[result.Count];

            for (int i = 0; i < result.Count; i++)
            {
                answer[i] = result[i];
            }

            return answer;
        }
    }

    // 예산
    public class Budget
    {
        public int solution(int[] d, int budget)
        {
            Array.Sort(d);

            int count = 0;

            for (int i = 0; i < d.Length; i++)
            {
                if (budget >= d[i])
                {
                    budget -= d[i];
                    count++;
                }
            }

            return count;
        }
    }

    // 3진법 뒤집기
    public class TernaryFlip
    {
        public int solution(int n)
        {
            Stack<int> value = new Stack<int>();
            int k = n;

            while (true)
            {
                if (k >= 3)
                {
                    value.Push(k % 3);
                    k = k / 3;
                }
                else
                {
                    value.Push(k);
                    break;
                }
            }

            int sum = 0;

            int count = value.Count;

            for (int i = 0; i < count; i++)
            {
                sum += (int)(value.Pop() * Math.Pow(3, i));
            }

            Console.WriteLine(sum);

            return sum;
        }
    }

    // 약수의 개수와 덧셈
    public class NumberAndAdditionOfFactors
    {
        public int solution(int left, int right)
        {
            int answer = 0;

            for (int i = left; i <= right; i++)
            {
                int count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                        count++;
                }

                if (count % 2 == 0)
                    answer += i;
                else
                    answer -= i;
            }

            return answer;
        }
    }

    // 체육복
    public class GymSuit
    {
        public int solution(int n, int[] lost, int[] reserve)
        {
            List<int> LostList = new List<int>(lost);
            List<int> ReserveList = new List<int>(reserve);
            List<int> RemoveList = new List<int>();

            int answer = 0;

            foreach (var num1 in LostList)
            {
                foreach (var num2 in ReserveList)
                {
                    if (num1 == num2)
                    {
                        RemoveList.Add(num2);
                        break;
                    }
                }
            }

            foreach (var num in RemoveList)
            {
                LostList.Remove(num);
                ReserveList.Remove(num);
            }

            for (int i = 0; i < LostList.Count; i++)
            {
                int left = LostList[i] - 1;
                int right = LostList[i] + 1;

                foreach (var num in ReserveList)
                {
                    if (num == left || num == right)
                    {
                        ReserveList.Remove(num);
                        answer++;
                        break;
                    }
                }
            }

            return n - (LostList.Count - answer);
        }
    }

    // 모의고사
    public class MockExam
    {
        public int[] solution(int[] answers)
        {
            int[] man1 = new int[] { 1, 2, 3, 4, 5 }; // 5반복
            int[] man2 = new int[] { 2, 1, 2, 3, 2, 4, 2, 5, }; // 8반복
            int[] man3 = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 }; // 10반복
            int[] check = new int[3];

            int max = 0;
            List<int> man = new List<int>();

            for (int i = 0; i < answers.Length; i++)
            {
                if (answers[i] == man1[i % 5])
                {
                    check[0]++;
                }
                if (answers[i] == man2[i % 8])
                {
                    check[1]++;
                }
                if (answers[i] == man3[i % 10])
                {
                    check[2]++;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (max < check[i])
                    max = check[i];
            }

            for (int i = 0; i < 3; i++)
            {
                if (max == check[i])
                    man.Add(i + 1);
            }

            return man.ToArray();
        }
    }

    // K번째 수
    public class KNumber
    {
        public int[] solution(int[] array, int[,] commands)
        {
            int lenth = commands.Length / 3;

            List<List<int>> datas = new List<List<int>>();

            for (int i = 0; i < lenth; i++)
            {
                datas.Add(new List<int>(array));
            }

            int[] answer = new int[commands.Length / 3];

            for (int i = 0; i < datas.Count; i++)
            {
                datas[i] = datas[i].GetRange(commands[i, 0] - 1, (commands[i, 1] - 1) - (commands[i, 0] - 1) + 1);
                datas[i].Sort();
                answer[i] = datas[i][commands[i, 2] - 1];
            }

            return answer;
        }
    }

    public class DecimalNumbersCreate
    {
        public int solution(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length - 2; i++)
            {
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        int num = nums[i] + nums[j] + nums[k];

                        bool check = false;

                        for (int t = 2; t < num; t++)
                        {
                            if (num % t == 0)
                            {
                                check = true;
                                break;
                            }
                        }

                        if (!check)
                            count++;
                    }
                }
            }

            return count;
        }
    }

    // 내적
    public class DotProduct
    {
        public int solution(int[] a, int[] b)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                count += a[i] * b[i];
            }

            return count;
        }
    }

    //음양 더하기
    public class PlusMinusFusion
    {
        public int solution(int[] absolutes, bool[] signs)
        {
            int count = 0;

            for (int i = 0; i < absolutes.Length; i++)
            {
                if (signs[i])
                    count += absolutes[i];
                else
                    count -= absolutes[i];
            }

            return count;
        }
    }

    // 없는 숫자 더하기
    public class NoneNumberPlus
    {
        public int solution(int[] numbers)
        {
            int answer = 0;

            for (int i = 0; i < numbers.Length; ++i)
                answer += numbers[i];

            return 45 - answer;
        }
    }

    // 숫자 문자열과 영단어
    public class NumberStringEnglishWords
    {
        public int solution(string s)
        {
            Dictionary<string, string> dicStr = new Dictionary<string, string>()
        {
             {"zero","0" },
             {"one","1" },
             {"two","2" },
             {"three","3" },
             {"four","4" },
             {"five","5" },
             {"six","6" },
             {"seven","7" },
             {"eight","8" },
             {"nine","9" },
         };

            foreach (var data in dicStr)
            {
                s = s.Replace(data.Key, data.Value);
            }
            int num = int.Parse(s);

            return num;
        }
    }

    // 로또의 최고 순위와 최저 순위
    public class LottoHighLowGrade
    {
        public int[] solution(int[] lottos, int[] win_nums)
        {
            int[] answer = new int[2];

            List<int> lottosList = new List<int>(lottos);
            List<int> win_numsList = new List<int>(win_nums);

            int count = 0;
            int etc = 0;
            // 기본적으로 맞은 수 
            for (int i = 0; i < lottosList.Count; i++)
            {
                if (lottosList[i] == 0)
                {
                    etc++;
                    continue;
                }

                if (win_numsList.Contains(lottosList[i]))
                {
                    count++;
                }
            }

            answer[0] = count;
            answer[1] = count + etc;

            for (int i = 0; i < 2; i++)
            {
                switch (answer[i])
                {
                    case 2:
                        answer[i] = 5;
                        break;
                    case 3:
                        answer[i] = 4;
                        break;
                    case 4:
                        answer[i] = 3;
                        break;
                    case 5:
                        answer[i] = 2;
                        break;
                    case 6:
                        answer[i] = 1;
                        break;
                    default:
                        answer[i] = 6;
                        break;
                }
            }

            if (answer[0] > answer[1])
            {
                int temp = answer[0];
                answer[0] = answer[1];
                answer[1] = temp;
            }

            return answer;
        }
    }

    // 최소 직사각형
    public class MinRectangle
    {
        public int solution(int[,] sizes)
        {
            for (int i = 0; i < sizes.GetLength(0); ++i)
            {
                int temp = 0;
                if (sizes[i, 0] < sizes[i, 1])
                {
                    temp = sizes[i, 0];
                    sizes[i, 0] = sizes[i, 1];
                    sizes[i, 1] = temp;
                }
            }

            int maxX = 0;
            int maxY = 0;

            for (int i = 0; i < sizes.GetLength(0); ++i)
            {
                if (maxX < sizes[i, 0])
                    maxX = sizes[i, 0];

                if (maxY < sizes[i, 1])
                    maxY = sizes[i, 1];
            }

            int answer = maxX * maxY;

            return answer;
        }
    }
}