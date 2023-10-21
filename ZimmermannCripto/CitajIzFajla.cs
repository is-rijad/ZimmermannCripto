namespace ZimmermannCripto {
    public class CitajIzFajla {
        public static char[][] Citaj() {
            int _velicina = 6;
            char[][] matrica = new char[_velicina][];

            var fileStreamOption = new FileStreamOptions()
            {
                Access = FileAccess.Read,
                Mode = FileMode.Open
            };

            using (var sr = new StreamReader("..//..//..//CodeBook.csv", fileStreamOption)) {
                for (int i = 0; i < _velicina; i++)
                {
                    matrica[i] = new char[_velicina];
                }


                while (sr.Peek() > -1) {
                    for (int i = 0; i < _velicina; i++) {
                        var str = sr.ReadLine().Split(',');

                        for (int j = 0; j < _velicina; j++) {
                            matrica[i][j] = char.Parse(str[j]);
                        }
                    }
                }
            }
            return matrica;
        }
    }
}