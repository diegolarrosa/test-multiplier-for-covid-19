using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * El programa realiza una serie de simulaciones, por ejemplo 1000.
 * En cada simulación toma una lista de personas y le asigna un valor aleatótio booleano, el cual indica si está infectado o no.
 * Luego realiza el proceso de búsqueda por test, para determinar cada persona si está infectada o no.
 * Devolviendo por cada simulación el número de test que fueron necesarios hacer para obtener el resultado.
 * En el resultado se indican cuantos test promedio se necesitaron en comparación con la muestra. También devuelve la eficiencia lograda.
 */
namespace SimulacionOptimizacion
{
    public partial class SimOT : Form
    {
        struct DSimulacionTest
        {
            public int multA;
            public int multB;
            public int nSim;
            public double nInfectadosPorMillon;
            public bool[] listaDePersonas;//por cada elemento en la lista, true -> infectado, false -> no infectado
        }

        private Random rmd;

        public SimOT()
        {
            InitializeComponent();
            rmd = new Random();
        }

        private void button_iniciar_simulacion_Click(object sender, EventArgs e)
        {
            button_iniciar_simulacion.Enabled = false;
            progressBar1.Visible = true;
            button_cancelar.Visible = true;
            progressBar1.Value = 0;

            DSimulacionTest st = new DSimulacionTest();
            st.multA = (int)numericUpDown_primera_etapa.Value;
            st.multB = (int)numericUpDown_segunda_etapa.Value;
            st.nSim = (int)numericUpDown_numero_de_simulaciones.Value;
            st.nInfectadosPorMillon = (double)numericUpDown_infectados_por_millon_supuesto.Value;
            st.listaDePersonas = new bool[st.multA * st.multB];
            textBox1_resultado.Text = "";
            backgroundWorker1.RunWorkerAsync(st);
        }

        /// <summary>
        /// Procesa una simulación, y devuelve el número de test que fueron necesarios
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        private int IndividualSimulacion(DSimulacionTest st)
        {
            int res = 0;

            //Carga el arreglo de personas, con datos aleatorios
            int p = (int)(1000000.0 / st.nInfectadosPorMillon);
            for (int i = 0; i < st.multA; i++)
            {
                for (int j = 0; j < st.multB; j++)
                {
                    st.listaDePersonas[i * st.multB + j] = rmd.Next(p) == 1;//También se puede poner "== 0", la idea es poner un número bajo que sea menor que p, donde p es probable que tome valores mayores a 1000, al menos que los infectados por millón tenga una cifra muy alta
                }
            }

            ////código auxiliar para contar la cantidad de infectados que produju la carga aleatoria
            //for (int i = 0; i < st.multA; i++)
            //{
            //    for (int j = 0; j < st.multB; j++)
            //    {
            //        if (st.listaDePersonas[i * st.multB + j])
            //        {
            //            res++;
            //        }
            //    }
            //}

            //Test primera etapa
            //Se prueban todos los casos al mismo tiempo, con un solo test
            res = 1;
            bool q = false;
            for (int i = 0; i < st.multA; i++)
            {
                for (int j = 0; j < st.multB; j++)
                {
                    if (st.listaDePersonas[i * st.multB + j])
                    {
                        //Se encontró al menos un infectado
                        q = true;
                        break;
                    }
                }
                if (q)
                {
                    break;
                }
            }
            if (!q)
            {
                return res;
            }

            //Test segunda etapa
            res += st.multA;
            for (int i = 0; i < st.multA; i++)
            {
                q = false;
                for (int j = 0; j < st.multB; j++)
                {
                    if (st.listaDePersonas[i * st.multB + j])
                    {
                        //Se encontró al menos un infectado
                        q = true;
                        break;
                    }
                }
                if (q)
                {
                    //Se tienen que realizar todos los test de la última etapa, para poder identificar los infectados
                    res += st.multB;
                }
            }

            return res;
        }

        private double BackgroundProcess_Simulacion(BackgroundWorker bw, DoWorkEventArgs e)
        {
            //double result = 0;
            int progress;
            int sumaCompleta = 0;
            DSimulacionTest st = (DSimulacionTest)e.Argument;

            for (int i = 0; i < st.nSim; i++)
            {
                //Thread.Sleep(10);
                int numeroDeTest = IndividualSimulacion(st);
                sumaCompleta += numeroDeTest;

                progress = (int)((i * 100.0) / st.nSim);
                bw.ReportProgress(progress);
                if (bw.CancellationPending)
                {
                    e.Cancel = true;
                    return 0;
                }
            }

            return (sumaCompleta * 100.0) / st.nSim;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = sender as BackgroundWorker;
            e.Result = BackgroundProcess_Simulacion(bw, e);
            if (bw.CancellationPending)
            {
                e.Cancel = true;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            button_iniciar_simulacion.Enabled = true;
            progressBar1.Visible = false;
            button_cancelar.Visible = false;

            if (e.Cancelled)
            {
                MessageBox.Show("Operación cancelada");
            }
            else if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else
            {
                double nTest = (double)(e.Result) / 100.0;
                int n1 = (int)numericUpDown_primera_etapa.Value;
                int n2 = (int)numericUpDown_segunda_etapa.Value;
                int nPersonas = n1 * n2;
                int ahorro = (int)(nPersonas - nTest);
                double eficiencia = (1.0 - (double)((double)nTest / (double)nPersonas)) * 100.0;
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Númeto de test promedio necesarios: " + string.Format("{0:0.00}", nTest));
                sb.AppendLine("Númeto de personas testeadas: " + nPersonas.ToString());
                sb.AppendLine("Ahorro de test: " + ahorro.ToString());
                sb.AppendLine("Eficiencia:  " + string.Format("{0:0.00}%", eficiencia));

                textBox1_resultado.Text = sb.ToString();
                //MessageBox.Show(e.Result.ToString());
                MessageBox.Show("La simulación finalizó correctamente");
            }
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
        }

        private void ActualizaMultiplicacion()
        {
            int n1 = (int)numericUpDown_primera_etapa.Value;
            int n2 = (int)numericUpDown_segunda_etapa.Value;
            int mult = n1 * n2;
            label_multiplicacion.Text = mult.ToString();
        }

        private void numericUpDown_primera_etapa_ValueChanged(object sender, EventArgs e)
        {
            ActualizaMultiplicacion();
        }

        private void numericUpDown_segunda_etapa_ValueChanged(object sender, EventArgs e)
        {
            ActualizaMultiplicacion();
        }
    }
}
