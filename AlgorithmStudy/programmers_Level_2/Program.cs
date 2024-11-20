using System.Text;


public class Program
{
    public static void Main(string[] args)
    {
        //JadenCaseTextCreate.solution("3people unFollowed me");
    }

    // 게임 맵 최단거리
    public class GameMapMinDistance
    {
        static int n = 0;
        static int m = 0;

        // 상하좌우
        static int[] dx = { 0, 0, -1, 1 };
        static int[] dy = { -1, 1, 0, 0 };

        static Queue<KeyValuePair<int, int>> queue = new Queue<KeyValuePair<int, int>>();

        public static int solution(int[,] maps)
        {
            n = maps.GetLength(0);
            m = maps.GetLength(1);

            BFS(0, 0, maps);

            if (maps[n - 1, m - 1] == 1)
                return -1;
            else
                return maps[n - 1, m - 1];
        }


        public static void BFS(int i, int j, int[,] maps)
        {
            queue.Enqueue(new KeyValuePair<int, int>(i, j));

            while (queue.Count != 0)
            {
                KeyValuePair<int, int> keyValue = queue.Dequeue();

                // 4방향 확인 
                for (int dis = 0; dis < 4; dis++)
                {
                    int x = keyValue.Key + dx[dis];
                    int y = keyValue.Value + dy[dis];

                    // 구역안에 있으며, 이동 가능한 위치
                    if ((x >= 0 && n > x) && (y >= 0 && m > y) && maps[x, y] == 1)
                    {
                        queue.Enqueue(new KeyValuePair<int, int>(x, y));

                        // 누적 처리
                        maps[x, y] = maps[keyValue.Key, keyValue.Value] + 1;
                    }
                }
            }
        }
    }


    // 올바른 괄호
    public class CorrectParenthesis
    {
        public bool solution(string s)
        {
            Queue<bool> check = new Queue<bool>();
            if (s[0] == ')' || s[s.Length - 1] == '(')
                return false;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                    check.Enqueue(false);
                else if (s[i] == ')')
                {
                    if (check.Count > 0)
                        check.Dequeue();
                    else
                        return false;
                }
            }

            if (check.Count > 0)
                return false;
            else
                return true;
        }
    }

    // 다음 큰 숫자
    public class NextBigNumber
    {
        public int solution(int n)
        {
            int answer = 0;
            int num = 0;

            string temp = Convert.ToString(n, 2);
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] == '1')
                    num++;
            }

            n++;
            while (true)
            {
                int count = 0;
                string str = Convert.ToString(n, 2);
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == '1')
                        count++;
                }

                if (num == count)
                {
                    answer = n;
                    break;
                }
                else
                    n++;
            }

            return answer;
        }
    }

    // 멀리 뛰기
    public class MaxDistanceJump
    {
        public static long solution(int n)
        {
            // 정리해보니 피보나치였음.. ㄷㄷ
            long answer = 0;

            // 다음 수부터 처리   
            long first = 1;
            long second = 1;

            if (n == 1)
                return 1;

            for (int i = 2; i <= n; i++)
            {
                answer = (first % 1234567) + (second % 1234567);
                first = second % 1234567;
                second = answer;
            }

            answer %= 1234567;

            return answer;
        }
    }

    // 최댓값과 최솟값
    public class MaxNumAndMinNum
    {
        public string solution(string s)
        {
            string[] str = s.Split(' ');
            string answer = "";
            List<int> data = new List<int>();

            for (int i = 0; i < str.Length; i++)
            {
                data.Add(int.Parse(str[i].ToString()));
            }

            data.Sort();

            answer = data[0].ToString() + " " + data[data.Count - 1].ToString();

            return answer;
        }
    }

    // 최솟값 만들기
    public class MinNumCreate
    {
        public int solution(int[] A, int[] B)
        {
            int answer = 0;
            Array.Sort(A);
            Array.Sort(B);
            Array.Reverse(B);

            for (int i = 0; i < A.Length; i++)
            {
                answer += A[i] * B[i];
            }

            return answer;
        }
    }

    // 피보나치 수
    public class Fibonacci
    {
        public int solution(int n)
        {
            int answer = 0;

            int first = 0;
            int second = 1;

            for (int i = 2; i <= n; i++)
            {
                answer = (first % 1234567) + (second % 1234567);
                answer = answer % 1234567;
                first = second % 1234567;
                second = answer;
            }

            return answer;
        }
    }

    // 하노이의 탑
    public static class HanoiTower
    {
        public static List<int> aPoint = new List<int>();
        public static List<int> bPoint = new List<int>();

        public static int[,] solution(int n)
        {
            Move(n, 1, 2, 3);

            int[,] answer = new int[aPoint.Count, 2];

            for (int i = 0; i < aPoint.Count; i++)
            {
                answer[i, 0] = aPoint[i];
                answer[i, 1] = bPoint[i];
            }

            return answer;
        }

        public static void Move(int height, int startPoint, int wayPoint, int goalPoint)
        {
            if (height <= 1)
            {
                // 해당 루트의 마지막 원판 경로 처리
                aPoint.Add(startPoint);
                bPoint.Add(goalPoint);
            }
            else
            {
                // 마지막 원판을 제외한 모든 원판은 출발지에서 경유지로 이동
                Move(height - 1, startPoint, goalPoint, wayPoint);

                // 마지막 원판 경로 처리
                aPoint.Add(startPoint);
                bPoint.Add(goalPoint);

                // 남은 원판 -> 경유지에서 목적지로 이동
                Move(height - 1, wayPoint, startPoint, goalPoint);
            }
        }
    }

    // 행렬의 곱셈
    public class MatrixMultiplication
    {
        public int[,] solution(int[,] arr1, int[,] arr2)
        {
            int[,] answer = new int[arr1.GetLength(0), arr2.GetLength(1)];

            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    for (int q = 0; q < arr2.GetLength(0); q++)
                    {
                        answer[i, j] += arr1[i, q] * arr2[q, j];
                    }
                }
            }

            return answer;
        }
    }

    // JadenCase 문자열 만들기
    public static class JadenCaseTextCreate
    {
        public static string solution(string s)
        {
            StringBuilder answer = new StringBuilder();

            char[] ch = s.ToLower().ToCharArray();

            answer.Append(ch[0].ToString().ToUpper());

            for (int i = 1; i < ch.Length; i++)
            {
                answer.Append(ch[i - 1] == ' ' ? ch[i].ToString().ToUpper() : ch[i].ToString());
            }

            return answer.ToString();
        }
    }

    // N-Queen ( 백트래킹 )
    public class NQueen
    {
        // 2차원 배열로 하다가 실패함 
        public int[] cols;

        public int solution(int n)
        {
            int answer = 0;
            cols = new int[n];

            answer = QueenRoot(0, n);

            return answer;
        }

        public int QueenRoot(int queenCount, int max)
        {
            int tempAnswer = 0;

            // 모든 퀸을 배치했다면 리턴 ( 행 )
            if (queenCount == max)
                return 1;
            else
            {
                // 모든 열 배치 및 체크 
                for (int i = 0; i < max; i++)
                {
                    // 배치 
                    cols[queenCount] = i;

                    // 상하좌우 대각선 배치 판단 
                    if (QueenCheck(queenCount) == true)
                    {
                        // 가능하다면 다음 퀸 출격 (다음 행)
                        tempAnswer += QueenRoot(queenCount + 1, max);
                    }
                }
            }

            // 초기화 
            cols[queenCount] = 0;

            return tempAnswer;
        }

        public bool QueenCheck(int checkValue)
        {
            for (int i = 0; i < checkValue; i++)
            {
                // 같은 열인지 체크 ( 상하 라인 )
                if (cols[checkValue] == cols[i])
                    return false;
                // 같은 대각선 체크 ( 대각 라인 = 합산의 절대값이 같음 )
                else if (Math.Abs(cols[checkValue] - cols[i]) == Math.Abs(checkValue - i))
                    return false;
            }

            return true;
        }
    }

    // N개의 최소공배수
    public class MinCommonMultiple
    {
        public int solution(int[] arr)
        {
            Array.Sort(arr);

            // 최대공약수 GCD(Greatest Common Divisor)
            int gcd;
            // 최소공배수 LCM(Least Common Multiple)
            int lcm = 0;

            // 가장 작은 두 개의 수로 최대공약수를 구한다.
            gcd = GCD(arr[1], arr[0]);
            // 최소 공배수 구함
            lcm = LCM(arr[1], arr[0], gcd);

            // 나머지 모든 수는 곱해서 최대공약수로 나눈다.
            for (int i = 2; i < arr.Length; i++)
            {
                lcm = LCM(lcm, arr[i], gcd);
            }

            return lcm;
        }

        // 최대 공약수
        public int GCD(int bigNum, int smallNum)
        {
            int temp = 0;

            while (smallNum != 0)
            {
                temp = bigNum % smallNum;
                bigNum = smallNum;
                smallNum = temp;
            }

            return bigNum;
        }

        // 최소 공배수
        public int LCM(int bigNum, int smallNum, int gcd)
        {
            if (gcd == 0)
                return 0;

            int result = (bigNum * smallNum) / GCD(bigNum, smallNum);

            return result;
        }
    }

    // 위장
    public class Camouflage
    {
        public int solution(string[,] clothes)
        {
            Dictionary<string, int> dicData = new Dictionary<string, int>();

            // 해당 부위별 옷의 개수
            for (int i = 0; i < clothes.GetLength(0); i++)
            {
                if (!dicData.ContainsKey(clothes[i, 1]))
                {
                    dicData.Add(clothes[i, 1], 1);
                }
                else
                    dicData[clothes[i, 1]] += 1;
            }

            int answer = 1;

            // 경우의 수 처리 (해당 종류의 옷개수 + 1), +1은 안입을 수 있기 때문이다.
            foreach (KeyValuePair<string, int> data in dicData)
            {
                answer *= (data.Value + 1);
            }

            // 옷을 전부 안입을 수는 없기때문에 -1 처리
            answer -= 1;

            return answer;
        }
    }

    // 다리를 지나는 트럭
    public class BridgeMoveTruck
    {
        public int solution(int bridge_length, int weight, int[] truck_weights)
        {
            int[] move = new int[truck_weights.Length];
            int index = 0;
            int answer = 0;

            while (true)
            {
                int sum = 0;
                for (int i = 0; i <= index; i++)
                {
                    // 0부터 현재 트럭까지 검사 ( 트럭이동이 다리 길이보다 짧을 경우, 현재 이동중이라는 트럭으로 판단 )
                    // sum에 더하는 것으로 이동중인 트럭으로 판단
                    if (move[i] > 0 && move[i] < bridge_length)
                    {
                        sum += truck_weights[i];
                    }
                }

                // 다음턴부터 체크, 트럭 무게 체크가 마지막인지, 합산된 무게+ 현재 진입할 트럭의 무게가 다리가 버티는 무게보다 적은지 판단
                if (answer > 0 && index < truck_weights.Length - 1 && sum + truck_weights[index + 1] <= weight)
                    index++;

                // 진입을 했던 트럭에서 아직 지나가는중인 트럭은 이동++
                for (int i = 0; i <= index; i++)
                {
                    if (move[i] <= bridge_length)
                    {
                        move[i]++;
                    }
                }

                answer++;

                // 마지막 트럭의 이동이 다리길이보다 크면 모든 트럭 지나감
                if (move[truck_weights.Length - 1] > bridge_length)
                    break;
            }

            return answer;
        }
    }

    // 주식가격
    public class StockPrice
    {
        public int[] solution(int[] prices)
        {
            int[] answer = new int[prices.Length];
            int count = 0;

            while (true)
            {
                int num = 0;
                for (int i = count + 1; i < prices.Length; i++)
                {
                    num++;
                    if (prices[i] < prices[count])
                        break;
                }

                answer[count] = num;

                count++;
                if (prices.Length == count)
                    break;
            }
            return answer;
        }
    }

    // 기능개발
    public class FunctionDevelopment
    {
        public int[] solution(int[] progresses, int[] speeds)
        {
            Queue<int> data = new Queue<int>(progresses);
            List<int> lists = new List<int>();
            int num = 0;
            int day = 1;

            int count = 0;

            bool check = false;
            while (true)
            {
                if (data.Peek() + day * speeds[num] >= 100)
                {
                    check = true;
                    data.Dequeue();
                    count++;
                    num++;
                }
                else
                {
                    check = false;
                    day++;
                }

                if (!check)
                {
                    if (count != 0)
                    {
                        lists.Add(count);
                        count = 0;
                    }
                }

                if (data.Count == 0)
                {
                    lists.Add(count);
                    break;
                }
            }

            int[] answer = lists.ToArray();
            return answer;
        }
    }

    // 프린트
    public class Printer
    {
        public class Paper
        {
            // 우선 순위
            public int priority = 0;
            // 위치
            public int location = 0;

            public Paper(int pr, int lo)
            {
                priority = pr;
                location = lo;
            }
        }

        public int solution(int[] priorities, int location)
        {
            Queue<Paper> que = new Queue<Paper>();

            for (int i = 0; i < priorities.Length; i++)
            {
                // 우선순위와 위치 초기화
                Paper data = new Paper(priorities[i], i);
                que.Enqueue(data);
            }

            int count = 1;

            while (que.Count > 0)
            {
                // 현재 큐의 우선순위 최대값
                int max = que.Max(x => x.priority);

                // 이후에 큐를 빼줘야 최대값 찾기 가능
                Paper temp = que.Dequeue();

                if (max == temp.priority)
                {
                    if (location == temp.location)
                        break;
                    count++;
                }
                // 우선순위가 아닐때 다시 뒤로간다.
                else
                {
                    que.Enqueue(temp);
                }
            }

            return count;
        }
    }

    // 배열 자르기 
    public class ArraySlide
    {
        //                               3         2          5
        public static int[] solution(int n, long left, long right)
        {
            List<int> data = new List<int>();

            // n * n의 배열 개수에서 Left에서 Right의 배열 인덱스를 체크
            // 나눗셈의 값은 행
            // 나눗셈의 나머지는 열
            // 위의 수로 이뤄짐을 알 수 있음

            for (long i = left; i <= right; i++)
            {
                int rowNum = (int)(i / n); // 행
                int colNum = (int)(i % n); // 열

                data.Add(rowNum > colNum ? (int)rowNum + 1 : (int)colNum + 1);
            }

            return data.ToArray();
        }
    }
}