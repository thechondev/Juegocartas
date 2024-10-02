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
            List<int> puntaje = new List<int>();
            List<int>esctrebol = new List<int>();
            List<int>escpica = new List<int>();
            List<int>esccorazon = new List<int>();
            List<int>escdiamante = new List<int>();

            int n = 0;
            foreach (Carta carta in cartas)
            {
                string pintac = "";
                contadores[(int)carta.obtenernom()]++;
                pintac = carta.obtenerpinta();
                switch (pintac)
                {
                    case "TREBOL":
                        esctrebol.Add((int)carta.obtenernom());
                        break;
                    case "PICA":
                        escpica.Add((int)carta.obtenernom());
                        break;
                    case "CORAZON":
                        esccorazon.Add((int)carta.obtenernom());
                        break;
                    default:
                        escdiamante.Add((int)(carta.obtenernom()));
                        break;
                }
                                                                                        
                n++;
            }
            esctrebol.Sort();
            escpica.Sort();
            esccorazon.Sort();
            escdiamante.Sort();
            

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
                
                for (int i = 0; i < esctrebol.Count; i++)
                {
                    if (i == esctrebol.Count - 1)
                    {
                        if (esctrebol.Count == 1 && contadores[esctrebol[i]] == 1)
                        {
                            if(esctrebol[i] == 10 || esctrebol[i] == 11 || esctrebol[i] == 12)
                            {
                                puntaje.Add(10);
                            }
                            else
                            {
                                puntaje.Add(esctrebol[i] + 1);
                            }
                        }
                        else if (contadores[esctrebol[i]] == 1 && !(esctrebol[i - 1] + 1 == esctrebol[i]))
                        {
                            if (esctrebol[i] == 10 || esctrebol[i] == 11 || esctrebol[i] == 12)
                            {
                                puntaje.Add(10);
                            }
                            else
                            {
                                puntaje.Add(esctrebol[i] + 1);
                            }
                            
                        }
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
                    else if (contadores[esctrebol[i]] == 1 && !(esctrebol[i - 1] + 1 == esctrebol[i]))
                    {
                        if (esctrebol[i] == 10 || esctrebol[i] == 11 || esctrebol[i] == 12)
                        {
                            puntaje.Add(10);
                        }
                        else
                        {
                            puntaje.Add(esctrebol[i]+1);
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

                for (int i = 0; i < escpica.Count; i++)
                {
                    if (escpica.Count == 1 && contadores[escpica[i]] == 1)
                    {
                        if (escpica[i] == 10 || escpica[i] == 11 || escpica[i] == 12)
                        {
                            puntaje.Add(10);
                        }
                        else
                        {
                            puntaje.Add(escpica[i] + 1);
                        }
                    }
                    else if (i == escpica.Count - 1)
                    {
                        if (contadores[escpica[i]] == 1 && !(escpica[i - 1] + 1 == escpica[i]))
                        {
                            if (escpica[i] == 10 || escpica[i] == 11 || escpica[i] == 12)
                            {
                                puntaje.Add(10);
                            }
                            else
                            {
                                puntaje.Add(escpica[i] + 1);
                            }
                            
                        }
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
                    else if (contadores[escpica[i]] == 1 && !(escpica[i - 1] + 1 == escpica[i]))
                    {
                        if (escpica[i] == 10 || escpica[i] == 11 || escpica[i] == 12)
                        {
                            puntaje.Add(10);
                        }
                        else
                        {
                            puntaje.Add(escpica[i]+1);
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

            //escaleras de corazon
            if (esccorazon.Sum() != 0)
            {

                for (int i = 0; i < esccorazon.Count; i++)
                {
                    if (esccorazon.Count == 1 && contadores[esccorazon[i]] == 1)
                    {
                        if (esccorazon[i] == 10 || esccorazon[i] == 11 || esccorazon[i] == 12)
                        {
                            puntaje.Add(10);
                        }
                        else
                        {
                            puntaje.Add(esccorazon[i] + 1);
                        }
                    }
                    else if (i == esccorazon.Count - 1)
                    {
                        if (contadores[esccorazon[i]] == 1 && !(esccorazon[i - 1] + 1 == esccorazon[i]))
                        {
                            if (esccorazon[i] == 10 || esccorazon[i] == 11 || esccorazon[i] == 12)
                            {
                                puntaje.Add(10);
                            }
                            else
                            {
                                puntaje.Add(esccorazon[i] + 1);
                            }
                        }
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
                    else if (contadores[esccorazon[i]] == 1 && !(esccorazon[i - 1] + 1 == esccorazon[i]))
                    {
                        if (esccorazon[i] == 10 || esccorazon[i] == 11 || esccorazon[i] == 12)
                        {
                            puntaje.Add(10);
                        }
                        else
                        {
                            puntaje.Add(esccorazon[i]+1);
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

                for (int i = 0; i < escdiamante.Count; i++)
                {
                    if (escdiamante.Count == 1 && contadores[escdiamante[i]] == 1)
                    {
                        if (escdiamante[i] == 10 || escdiamante[i] == 11 || escdiamante[i] == 12)
                        {
                            puntaje.Add(10);
                        }
                        else
                        {
                            puntaje.Add(escdiamante[i] + 1);
                        }
                    }
                    else if (i == escdiamante.Count - 1)
                    {
                        if (contadores[escdiamante[i]] == 1 && !(escdiamante[i - 1] + 1 == escdiamante[i]))
                        { 
                            if (escdiamante[i] == 10 || escdiamante[i] == 11 || escdiamante[i] == 12)
                            {
                                puntaje.Add(10);

                            }
                            else
                            {
                                puntaje.Add(escdiamante[i] + 1);
                            }
                        }
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
                    else if (contadores[escdiamante[i]] == 1 && !(escdiamante[i - 1] + 1 == escdiamante[i]))
                    {
                        if (escdiamante[i] == 10 || escdiamante[i] == 11 || escdiamante[i] == 12)
                        {
                            puntaje.Add(10);
                            
                        }
                        else
                        {
                            puntaje.Add(escdiamante[i]+1);
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
            mensaje += "el puntaje es " + (puntaje.Sum()).ToString();
            return mensaje;
        }
    }
}
