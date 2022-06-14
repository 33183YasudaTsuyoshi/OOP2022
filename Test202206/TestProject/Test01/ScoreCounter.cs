using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {

            _score = ReadScore(filePath);

        }


        //メソッドの概要： 
        private static IEnumerable<Student> ReadScore(string filePath) {
            List<Student> sales = new List<Student>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines) {
                string[] items = line.Split(',');
                Student sale = new Student {
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };
                sales.Add(sale);
            }
            return sales;

        }

        //メソッドの概要： 
        public IDictionary<string, int> GetPerStudentScore() {

            var dict = new Dictionary<string, int>(); 

            foreach (var score in _score) {
                if (dict.ContainsKey(score.Subject)) {
                    dict[score.Subject] += score.Score;
                } else {
                    dict[score.Subject] = score.Score;
                }
            }

            return dict;

        }
    }
}
