using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juegocartas
{
    public class Jugador()
    {
        private const int TOTAL_CARTAS = 10;
        private Carta[] cartas;
        private int[] ordcart;
        private Random r = new Random();

        public void Repartir()
        {
            cartas = new Carta[TOTAL_CARTAS];
            for (int i = 0; i < TOTAL_CARTAS; i++)
            {
                cartas[i] = new Carta(r);
            }

        }

        public void mostrar (ListView lv)
        {
            foreach (Carta carta in cartas)
            {
                carta.mostrar(lv);
                
            }
        }

        int posicioncontador = 0;
        private Carta ultcarta;
        private Carta sigcarta;
        

        public string obtenergrupos()
        {
            string mensaje = "No se encontraron grupos";
            int[] contadores = new int[Enum.GetValues(typeof(Nombrec)).Length];
            int[] esctrebol = new int[TOTAL_CARTAS];
            int[] escpica = new int[TOTAL_CARTAS];
            int[] esccorazon = new int[TOTAL_CARTAS];
            int[] escdiamante = new int[TOTAL_CARTAS];

            int n = 0;
            foreach (Carta carta in cartas)
            {
                string pintac = "";
                contadores[(int)carta.obtenernom()]++;
                pintac = carta.obtenerpinta();
                switch (pintac)
                {
                    case "TREBOL":
                        esctrebol[n] = (int)carta.obtenernom();
                        break;
                    case "PICA":
                        escpica[n] = (int)carta.obtenernom();
                        break;
                    case "CORAZON":
                        esccorazon[n] = (int)carta.obtenernom();
                        break;
                    default:
                        escdiamante[n] = (int)(carta.obtenernom());
                        break;
                }
                                                                                        
                n++;
            }

            Array.Sort(esctrebol);
            Array.Sort(escpica);
            Array.Sort(esccorazon);
            Array.Sort(escdiamante);
            

            int m = 1;
            int grupoesc = 0;
            bool haygrupos = false;
            foreach (int contador in contadores)
            {
                if (contador >= 2)
                {
                    if (!haygrupos)
                    {
                        mensaje = "Se encontraron los siguientes grupos:\n";
                        haygrupos = true;
                    }

                    m = 1;
                    if (posicioncontador == 13)
                    {
                        posicioncontador = 12;
                    }    
                    mensaje += Enum.GetValues(typeof(Grupo)).GetValue(contador).ToString()+
                        " de "+ Enum.GetValues(typeof(Nombrec)).GetValue(posicioncontador) + "\n";
                    
                   
                }
                posicioncontador += 1;

            }
            posicioncontador = 0;
            if (esctrebol.Sum() != 0)
            {
                
                for (int i = 0; i < esctrebol.Length; i++)
                {
                    if (i  == esctrebol.Length-1)
                    {
                        break;
                    }
                    if ((esctrebol[i]!= 0) && (esctrebol[i]+1 == esctrebol[i+1]) || (esctrebol[i]==0 && esctrebol[i+1]==1))
                    {
                        grupoesc += 1;
                        if (!haygrupos)
                        {
                            mensaje = "Se encontraron los siguientes grupos:\n";
                            haygrupos = true;
                        }
                    }

                }
                if (grupoesc != 0)
                {
                    grupoesc += 1;
                    if (grupoesc > 10)
                    {
                        grupoesc = 10;
                    }

                    mensaje += "Escalera de " + Enum.GetValues(typeof(Grupo)).GetValue(grupoesc).ToString() +
                    " de " + "Trebol" + "\n";
                    grupoesc = 0;
                }
            }
           
            if (escpica.Sum() != 0)
            {

                for (int i = 0; i < escpica.Length; i++)
                {
                    if (i == escpica.Length - 1)
                    {
                        break;
                    }
                    if ((escpica[i] != 0) && (escpica[i] + 1 == escpica[i + 1]) || (escpica[i] == 0 && escpica[i + 1] == 1))
                    {
                        grupoesc += 1;
                        if (!haygrupos)
                        {
                            mensaje = "Se encontraron los siguientes grupos:\n";
                            haygrupos = true;
                        }
                    }

                }
                if (grupoesc != 0)
                {
                    grupoesc += 1;
                    if (grupoesc > 10)
                    {
                        grupoesc = 10;
                    }

                    mensaje += "Escalera de " + Enum.GetValues(typeof(Grupo)).GetValue(grupoesc).ToString() +
                    " de " + "pica" + "\n";
                    grupoesc = 0;
                }
            }

            if (esccorazon.Sum() != 0)
            {

                for (int i = 0; i < esccorazon.Length; i++)
                {
                    if (i == esccorazon.Length - 1)
                    {
                        break;
                    }
                    if ((esccorazon[i] != 0) && (esccorazon[i] + 1 == esccorazon[i + 1]) || (esccorazon[i] == 0 && esccorazon[i + 1] == 1))
                    {
                        grupoesc += 1;
                        if (!haygrupos)
                        {
                            mensaje = "Se encontraron los siguientes grupos:\n";
                            haygrupos = true;
                        }
                    }

                }
                if (grupoesc != 0)
                {
                    grupoesc += 1;
                    if (grupoesc > 10)
                    {
                        grupoesc = 10;
                    }

                    mensaje += "Escalera de " + Enum.GetValues(typeof(Grupo)).GetValue(grupoesc).ToString() +
                    " de " + "corazon" + "\n";
                    grupoesc = 0;
                }
            }

            if (escdiamante.Sum() != 0)
            {

                for (int i = 0; i < escdiamante.Length; i++)
                {
                    if (i == escdiamante.Length - 1)
                    {
                        break;
                    }
                    if ((escdiamante[i] != 0) && (escdiamante[i] + 1 == escdiamante[i + 1]) || (escdiamante[i] == 0 && escdiamante[i + 1] == 1))
                    {
                        grupoesc += 1;
                        if (!haygrupos)
                        {
                            mensaje = "Se encontraron los siguientes grupos:\n";
                            haygrupos = true;
                        }
                    }

                }
                if (grupoesc != 0)
                {
                    grupoesc += 1;
                    if (grupoesc > 10)
                    {
                        grupoesc = 10;
                    }

                    mensaje += "Escalera de " + Enum.GetValues(typeof(Grupo)).GetValue(grupoesc).ToString() +
                    " de " + "diamante" + "\n";
                    grupoesc = 0;
                }
            }
            return mensaje;
        }
    }
}
