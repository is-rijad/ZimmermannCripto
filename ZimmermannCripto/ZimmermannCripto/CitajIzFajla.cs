namespace ZimmermannCripto {
    public class CitajIzFajla {
        public static char[][] Citaj() {
            char[][] matrica = new char[6][];
            int _velicina = 6;

            var fileStreamOption = new FileStreamOptions()
            {
                Access = FileAccess.Read,
                Mode = FileMode.Open
            };

            using (var sr = new StreamReader("CodeBook.csv", fileStreamOption)) {
                matrica[0] = new char[6];
                matrica[1] = new char[6];
                matrica[2] = new char[6];
                matrica[3] = new char[6];
                matrica[4] = new char[6];
                matrica[5] = new char[6];


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