using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SimulacionDados
{
    class Dado
    {
        Random r = new Random(DateTime.Now.Millisecond);
        Random r1 = new Random(DateTime.Now.Millisecond);

        int[] _Dado = new int[100];
        int[] _RDado = new int[100];


        public Dado()
        {
            Thread.Sleep(1);
        }

        public string Lanzar()
        {
            int x = 0, y = 0;
            string cadena = "";
            for (int i = 0; i < 100; i++)//hasta el 99==100
            {
                x = r.Next(1,7);//dado 1
                y = r1.Next(1, 7);//dado 2
                //sumar dados
                _Dado[i]= x + y;
            }

            for (int i = 0; i<100; i++)
            {
                for (int j = 0; j<100; j++)
                {
                    if (_Dado[i]==_Dado[j])
                    {
                        _RDado[i] += 1;
                    }
                }
            }

            for (int i = 0; i < 100; i++)
            {
                cadena += (i+1)+" ---------> El "+_Dado[i] + " se repite---------> " + _RDado[i] + " veces."+Environment.NewLine;
            }
            return cadena;
        }

        public string lanzarDoble()
        {
            string cadena = "";
            for(int i=0; i<100; i++)
            {
                _Dado[i] = r.Next(1, 7);

            }
            for (int i=0; i < 100; i++)
            {
                for (int j=0; j<100; j++)
                {
                    if (_Dado[i] == _Dado[j])
                    {
                        _RDado[i]+= 1;
                    }
                }
            }
            for (int i=0; i<100; i++)
            {
                cadena += (i + 1) + "--------> El " + _Dado[i] + " se repite--------> " + _RDado[i] + " veces." + Environment.NewLine;
            }
            return cadena;
        }
        
    }
}
