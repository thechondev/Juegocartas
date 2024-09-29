
namespace Juegocartas
{
    public class Carta
    {
        private int indice;

        public Carta(Random r)
        {
            indice = r.Next(52) + 1;
        }

        public string obtenerpinta()
        {

            if (indice <= 13)
            {
                return "TREBOL";
            }
            else if (indice <= 26)
            {
                return "PICA";
            }
            else if (indice <= 39)
            {
                return "CORAZON";
            }
            else
            {
                return "DIAMANTE";
            }

        }


        public Nombrec obtenernom()
        {
            int residuo = indice % 13;

            if (residuo == 0)
            {
                residuo = 13;
            }

            return (Nombrec)Enum.GetValues(typeof(Nombrec)).GetValue(residuo - 1);
        }

        public void mostrar(ListView lv)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.ImageIndex = indice - 1;
            lv.Items.Add(lvi);
        }
    }
}
