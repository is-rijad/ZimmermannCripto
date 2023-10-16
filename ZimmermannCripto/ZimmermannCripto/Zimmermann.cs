namespace ZimmermannCripto {
    public partial class Frm_Zimmermann : Form {
        private readonly char[][] _codeBook;
        private readonly char[] _charovi = new char[6];
        private const int _velicina = 6;
        private bool _enkripcija;

        public Frm_Zimmermann() {
            InitializeComponent();
            _codeBook = CitajIzFajla.Citaj();
            Incijalizuj();
        }

        private void Incijalizuj() {
            _charovi[0] = 'D';
            _charovi[1] = 'V';
            _charovi[2] = 'B';
            _charovi[3] = 'E';
            _charovi[4] = 'N';
            _charovi[5] = 'K';
        }

        private void Frm_Zimmermann_Load(object sender, EventArgs e) {
            rb_Encryption.Checked = true;
            _enkripcija = true;
        }

        private void rb_Encryption_CheckedChanged(object sender, EventArgs e) {
            btn_Izvrsi.Text = "Enkriptuj";
            _enkripcija = true;
            Ocisti();
        }

        private void rb_Decryption_CheckedChanged(object sender, EventArgs e) {
            btn_Izvrsi.Text = "Dekriptuj";
            _enkripcija = false;
            Ocisti();
        }

        private void Ocisti() {
            txt_Unos.Text = string.Empty;
            txt_Rezultat.Text = string.Empty;
        }

        private async void btn_Izvrsi_Click(object sender, EventArgs e) {
            if (_enkripcija) 
                txt_Rezultat.Text = await Enkriptuj(txt_Unos.Text);
            else
                txt_Rezultat.Text = await Dekriptuj(txt_Unos.Text);
        }

        private async Task<string> Enkriptuj(string unos) {
            unos = unos.ToUpper();
            unos = unos.Replace(" ", "");
            string rezultat = string.Empty;

            for (int i = 0; i < unos.Length; i++) {
                for (int j = 0; j < _velicina; j++) {
                    for (int k = 0; k < _velicina; k++) {
                        if (unos[i] == _codeBook[j][k]) {
                            rezultat += _charovi[j];
                            rezultat += _charovi[k];
                        }
                    }
                }
            }
            return rezultat;
        }

        private async Task<string> Dekriptuj(string unos) {
            string rezultat = string.Empty;
            int charIndex0;
            int charIndex1;

            unos = unos.ToUpper();

            for (int i = 0; i < unos.Length; i += 2) {
                charIndex0 = 0;
                charIndex1 = 0;

                for (int j = 0; j < _velicina; j++) {
                    if (unos[i] == _charovi[j]) 
                        charIndex0 = j;
                }
                for (int j = 0; j < _velicina; j++) {
                    if (unos[i + 1] == _charovi[j])
                        charIndex1 = j;
                }
                rezultat += _codeBook[charIndex0][charIndex1];
            }
            return rezultat;
        }
    }
}