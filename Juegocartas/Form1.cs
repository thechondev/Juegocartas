namespace Juegocartas
{
    public partial class Wjuego : Form
    {
        Jugador jugador1, jugador2;

        public Wjuego()
        {
            InitializeComponent();
            jugador1 = new Jugador();
            jugador2 = new Jugador();

        }

        private void tscmdrepartir_Click(object sender, EventArgs e)
        {
            lvjugador1.Clear();
            jugador1.Repartir();
            jugador1.mostrar(lvjugador1);

            lvjugador2.Clear();
            jugador2.Repartir();
            jugador2.mostrar(lvjugador2);
        }

        private void tscmdverificar_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    MessageBox.Show(jugador1.obtenergrupos());
                    break;
                case 1:
                    MessageBox.Show(jugador2.obtenergrupos());
                    break;

            }
        }
    }
}
