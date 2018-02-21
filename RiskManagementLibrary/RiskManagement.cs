using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace RiskManagementLibrary
{
    /// <summary>
    /// dfghjk
    /// </summary>
    [Serializable]
    public class RiskManagementLib
    {
        public string Login { get; set; }
        public string Parol { get; set; }
        public int number { get; set; }
        public int isCorrect { get; set; } // 0- неправильна реєстрація. 1 - запит даних. 2 - вставка даних.

        public int[][] IdentifyRisk = new int[4][];
        public double[] percentRisk = new double[5];
        public string[] technical = new string[] { "Множина джерел появи технічних ризиків", " функціональні характеристики ПЗ,", " характеристики якості ПЗ,", "характеристики надійності ПЗ,", "застосовність ПЗ,", " часова продуктивність ПЗ,", "супроводжуваність ПЗ,", "повторне використання компонент ПЗ;" };
        public string[] valueRisks = new string[] { "Множина джерел появи вартісних ризиків", " обмеження сумарного бюджету на програмний проект,", "недоступна вартість реалізації програмного проекту,", "низька ступінь реалізму при оцінюванні витрат на програмний проект;" };
        public string[] planRisks = new string[] { "Множина джерел появи планових ризиків", "властивості та можливості гнучкості внесення змін до планів життєвого циклу розроблення ПЗ,", "можливості порушення встановлених термінів реалізації етапів життєвого цик-лу розроблення ПЗ,", "низька ступінь реалізму при встановленні планів і етапів життєвого циклу роз-роблення ПЗ;" };
        public string[] procesRisks = new string[] { "Множина джерел появи ризиків реалізації процесів і процедур управління ", "хибна стратегія реалізації програмного проекту,", "неефективне планування проекту розроблення ПЗ,", "неякісне оцінювання програмного проекту,", "прогалини в документуванні етапів реалізації програмного проекту,", "промахи в прогнозуванні результатів реалізації програмного проекту." };

        public int[][] eventIdentifyRisk = new int[4][];
        public double[] eventPercentRisk = new double[5];
        public string[] eventTechnical = new string[] { "Множина настання технічних ризикових подій", "затримки у постачанні обладнання, необхідного для підтримки процесу розроблення ПЗ;", "затримки у постачанні інструментальних засобів, необхідних для підтримки процесу розроблення ПЗ;", "небажання команди виконавців ПЗ використовувати інструментальні засоби для підтримки процесу розроблення ПЗ;", "відмова команди виконавців від CASE-засобів розроблення ПЗ;", "формування запитів на більш потужні інструментальні засоби розроблення ПЗ;", "недостатня продуктивність баз(и) даних для підтримки процесу розроблення ПЗ;", "програмні компоненти, які використовують повторно в ПЗ, мають дефeкти та обмежені функціональні можливості;", "неефективність програмного коду, згенерованого CASE-засобами розроблення ПЗ;", "неможливість інтеграції CASE-засобів з іншими інструментальними засобами для підтримки процесу розроблення ПЗ;", "швидкість виявлення дефектів у програмному коді є нижчою від раніше запланованих термінів;", "поява дефектних системних компонент, які використовують для розроблення ПЗ;" };
        public string[] eventValueRisks = new string[] { "Множина настання вартісних ризикових подій", " недооцінювання витрат на реалізацію програмного проекту (надмірно низька вартість);", "переоцінювання витрат на реалізацію програмного проекту (надмірно висока вартість);", "фінансові ускладнення у компанії-замовника ПЗ;", "фінансові ускладнення у компанії-розробника ПЗ;", "збільшення бюджету програмного проекта з ініціативи компанії-розробника ПЗ під час його реалізації;", "зменшення бюджету програмного проекта з ініціативи компанії-розробника ПЗ під час його реалізації;", "висока вартість виконання повторних робіт, необхідних для зміни вимог до ПЗ;", "реорганізація структурних підрозділів у компанії-замовника ПЗ;", "реорганізація команди виконавців у компанії-розробника ПЗ;" };
        public string[] eventPlanRisks = new string[] { "Множина настання планових ризикових подій", "зміни графіка виконання робіт з боку замовника чи виконавця;", "порушення графіка виконання робіт у компанії-розробника ПЗ;", "потреба зміни користувацьких вимог до ПЗ з боку компанії-замовника ПЗ;", "потреба зміни функціональних вимог до ПЗ з боку компанії-розробника ПЗ;", "потреба виконання великої кількості повторних робіт, необхідних для зміни вимог до ПЗ;", "недооцінювання тривалості етапів реалізації програмного проекту з боку компанії-розробника ПЗ;", "переоцінювання тривалості етапів реалізації програмного проекту;", "остаточний розмір ПЗ перевищує заплановані його характеристики;", "остаточний розмір ПЗ значно менший за планові його характеристики;", "поява на ринку аналогічного ПЗ до виходу замовленого;", "поява на ринку більш конкурентоздатного ПЗ;" };
        public string[] eventProcesRisks = new string[] { "Множина настання ризикових подій реалізації процесів і процедур управління програмним проектом", "низький моральний стан персоналу команди виконавців ПЗ;", "низька взаємодія між членами команди виконавців ПЗ;", "пасивність керівника (менеджера) програмного проекту;", "недостатня компетентність керівника (менеджера) програмного проекту;", "незадоволеність замовника результатами етапів реалізації програмного проекту;", "недостатня кількість фахівців у команді виконавців ПЗ з необхідним професійним рівнем;", "хвороба провідного виконавця в найкритичніший момент розроблення ПЗ;", "одночасна хвороба декількох виконавців підчас розроблення ПЗ;", "неможливість організації необхідного навчання персоналу команди виконавців ПЗ;", "зміна пріоритетів у процесі управління програмним проектом;", "недооцінювання необхідної кількості розробників (підрядників і суб-підрядників) на етапах життєвого циклу розроблення ПЗ;", "переоцінювання необхідної кількості розробників (підрядників і суб-підрядників) на етапах життєвого циклу розроблення ПЗ;", "надмірне документування результатів на етапах реалізації програмного проекту;", "недостатнє документування результатів на етапах реалізації програмного проекту;", "нереалістичне прогнозування результатів на етапах реалізації програмного проекту;", "недостатній професійний рівень представників від компанії-замовника ПЗ." };

        // public double[] arithmeticMeanRisk = new double[4];
        public double[][,] analisIdentifyRisk = new double[4][,];
        public double[][,] analisRiskWithValidity = new double[4][,];
        public IntPtr FormAnalisProcess { get;  set; }
        public IntPtr FormPotentialRiskEventsProcess { get;  set; }
        public IntPtr FormSourcesProcess { get;  set; }

        public RiskManagementLib ShallowCopy()
        {
            return (RiskManagementLib)this.MemberwiseClone();
        }
        public RiskManagementLib()
        {
            IdentifyRisk[0] = new int[8];
            IdentifyRisk[1] = new int[4];
            IdentifyRisk[2] = new int[4];
            IdentifyRisk[3] = new int[6];

            eventIdentifyRisk[0] = new int[12];
            eventIdentifyRisk[1] = new int[10];
            eventIdentifyRisk[2] = new int[12];
            eventIdentifyRisk[3] = new int[17];

            analisIdentifyRisk[0] = new double[12, 11];
            analisIdentifyRisk[1] = new double[10, 11];
            analisIdentifyRisk[2] = new double[12, 11];
            analisIdentifyRisk[3] = new double[17, 11];

            analisRiskWithValidity[0] = new double[12, 11];
            analisRiskWithValidity[1] = new double[10, 11];
            analisRiskWithValidity[2] = new double[12, 11];
            analisRiskWithValidity[3] = new double[17, 11];

            Rand(IdentifyRisk);
            Rand(eventIdentifyRisk);
            Rand(analisIdentifyRisk);
            // Rand(analisRiskWithValidity);
            Random r = new Random();
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    analisIdentifyRisk[j][0, i] = r.Next(5, 11);
                    analisRiskWithValidity[j][0, i] = analisIdentifyRisk[j][0, i];
                }
            }

        }
        private void Rand(int[][] data)
        {

            Random rand = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < data[i].Length; j++)
                {
                    data[i][j] = rand.Next(0, 2);
                }
            }
        }
        private void Rand(double[][,] data)
        {

            Random rand = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int k = 0; k < 10; k++)
                {
                    for (int j = 1; j < data[i].Length / 11; j++)
                    {
                        data[i][j, k] = Math.Round(rand.NextDouble(), 2);
                    }
                }

            }
        }
        public void CountAnalisIdentifyRisk()
        {
            var Sum = 0.0;
            for (int i = 0; i < 4; i++)
            {
                int j = 0;
                for (j = 0; j < analisIdentifyRisk[i].Length / 11; j++)
                {
                    analisIdentifyRisk[i][j, 10] = 0;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                Sum = 0;
                int j = 0;
                for (int s = 0; s < 10; s++)
                {
                    Sum += analisIdentifyRisk[i][0, s];
                }
                analisIdentifyRisk[i][0, 10] = Sum;
                Sum = 0;
                for (j = 1; j < analisIdentifyRisk[i].Length / 11; j++)
                {
                    Sum = 0;
                    for (int s = 0; s < 10; s++)
                    {
                        if (s == 9)
                            Sum += 0;
                        Sum += analisIdentifyRisk[i][j, s];
                    }
                    analisIdentifyRisk[i][j, 10] = Sum / 10.0;
                }
            }
        }
        public void CountIdentyfyRisk()
        {
            IdentifyRisk[0][0] = 0;
            IdentifyRisk[1][0] = 0;
            IdentifyRisk[2][0] = 0;
            IdentifyRisk[3][0] = 0;
            for (int i = 1; i < IdentifyRisk[0].Length; i++)
            {
                IdentifyRisk[0][0] += IdentifyRisk[0][i];
            }
            for (int i = 1; i < IdentifyRisk[1].Length; i++)
            {
                IdentifyRisk[1][0] += IdentifyRisk[1][i];
            }
            for (int i = 1; i < IdentifyRisk[2].Length; i++)
            {
                IdentifyRisk[2][0] += IdentifyRisk[2][i];
            }
            for (int i = 1; i < IdentifyRisk[3].Length; i++)
            {
                IdentifyRisk[3][0] += IdentifyRisk[3][i];
            }
            percentRisk[1] = IdentifyRisk[0][0] / 18.0;
            percentRisk[2] = IdentifyRisk[1][0] / 18.0;
            percentRisk[3] = IdentifyRisk[2][0] / 18.0;
            percentRisk[4] = IdentifyRisk[3][0] / 18.0;
            percentRisk[0] = percentRisk[1] + percentRisk[2] + percentRisk[3] + percentRisk[4];
        }

        public void CountAnalisRiskWithValidity()
        {
            var Sum = 0.0;
            var SumOfSum = 0.0;
            for (int k = 0; k < 4; k++)
            {
                for (int i = 1; i < analisRiskWithValidity[k].Length / 11; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        analisRiskWithValidity[k][i, j] = Math.Round(analisIdentifyRisk[k][i, j] * analisIdentifyRisk[k][0, j] * eventIdentifyRisk[k][i], 2);
                        Sum += analisRiskWithValidity[k][i, j];
                    }
                    analisRiskWithValidity[k][i, 10] = Math.Round(Sum / analisIdentifyRisk[k][0, 10], 3);
                    Sum = 0;
                    SumOfSum += analisRiskWithValidity[k][i, 10];
                }
                analisRiskWithValidity[k][0, 10] = SumOfSum / (analisRiskWithValidity[k].Length / 11);
                SumOfSum = 0;

                for (int j = 0; j < 10; j++)
                {
                    for (int i = 1; i < analisRiskWithValidity[k].Length / 11; i++)
                    {
                        Sum += analisRiskWithValidity[k][i, j];
                    }
                    analisRiskWithValidity[k][0, j] = Sum/ (analisRiskWithValidity[k].Length / 11);
                    analisRiskWithValidity[k][0, j] = analisRiskWithValidity[k][0, j] / analisIdentifyRisk[k][0, j];
                    Sum = 0;
                }
            }
        }

        public void CountPotentialRiskEvents()
        {
            eventIdentifyRisk[0][0] = 0;
            eventIdentifyRisk[1][0] = 0;
            eventIdentifyRisk[2][0] = 0;
            eventIdentifyRisk[3][0] = 0;
            for (int i = 1; i < eventIdentifyRisk[0].Length; i++)
            {
                eventIdentifyRisk[0][0] += eventIdentifyRisk[0][i];
            }
            for (int i = 1; i < eventIdentifyRisk[1].Length; i++)
            {
                eventIdentifyRisk[1][0] += eventIdentifyRisk[1][i];
            }
            for (int i = 1; i < eventIdentifyRisk[2].Length; i++)
            {
                eventIdentifyRisk[2][0] += eventIdentifyRisk[2][i];
            }
            for (int i = 1; i < eventIdentifyRisk[3].Length; i++)
            {
                eventIdentifyRisk[3][0] += eventIdentifyRisk[3][i];
            }
            eventPercentRisk[1] = eventIdentifyRisk[0][0] / 46.0;
            eventPercentRisk[2] = eventIdentifyRisk[1][0] / 46.0;
            eventPercentRisk[3] = eventIdentifyRisk[2][0] / 46.0;
            eventPercentRisk[4] = eventIdentifyRisk[3][0] / 46.0;
            eventPercentRisk[0] = eventPercentRisk[1] + eventPercentRisk[2] + eventPercentRisk[3] + eventPercentRisk[4];
        }
    }
    public class Convertor
    {
        public static byte[] ObjectToByteArray(Object obj)
        {
            if (obj == null)
                return null;
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, obj);
            return ms.ToArray();
        }

        public static Object ByteArrayToObject(byte[] arrBytes)
        {
            MemoryStream memStream = new MemoryStream();
            BinaryFormatter binForm = new BinaryFormatter();
            memStream.Write(arrBytes, 0, arrBytes.Length);
            memStream.Seek(0, SeekOrigin.Begin);
            Object obj = (Object)binForm.Deserialize(memStream);
            return obj;
        }
        public static Object ByteArrayToObject(byte[] arrBytes,int size)
        {
            MemoryStream memStream = new MemoryStream();
            BinaryFormatter binForm = new BinaryFormatter();
            memStream.Write(arrBytes, 0, size);
            memStream.Seek(0, SeekOrigin.Begin);
            Object obj = (Object)binForm.Deserialize(memStream);
            return obj;
        }
    }
}
