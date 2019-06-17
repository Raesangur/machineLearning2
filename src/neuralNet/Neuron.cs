using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace machineLearning2
{
    class Neuron
    {
        private machineLearning2 father;
        /* Public variables */
        public string Name;
        public int Column;
        public int Line;
        public double Bias = 0.0;
        public double Output = 0.0;
        public double Input = 0.0;

        #region Constructors
        public Neuron(machineLearning2 parent, string name)
        {
            father = parent;
            Name = name;

            father.WriteLine("Neuron " + name + " created! | " + Bias.ToString(), LogLevel_t.info);
        }

        public Neuron(machineLearning2 parent, string name, int column, int line)
        {
            father = parent;
            Name = name;
            Column = column;
            Line = line;

            father.WriteLine("Neuron " + name + " created! | " + Bias.ToString(), LogLevel_t.info);
        }

        public Neuron(machineLearning2 parent, string name, double bias)
        {
            father = parent;
            Name = name;
            Bias = bias;

            father.WriteLine("Neuron " + name + " created! | " + Bias.ToString(), LogLevel_t.info);
        }

        public Neuron(machineLearning2 parent, string name, double bias, double input)
        {
            father = parent;
            Name = name;
            Bias = bias;
            Input = input;

            father.WriteLine("Neuron " + name + " created! | " + Bias.ToString(), LogLevel_t.info);
        }

        public Neuron(machineLearning2 parent, string name, double bias, int column, int line)
        {
            father = parent;
            Name = name;
            Bias = bias;
            Column = column;
            Line = line;

            father.WriteLine("Neuron " + name + " created! | " + Bias.ToString(), LogLevel_t.info);
        }

        public Neuron(machineLearning2 parent, string name, double bias, double input, int column, int line)
        {
            father = parent;
            Name = name;
            Bias = bias;
            Input = input;
            Column = column;
            Line = line;

            father.WriteLine("Neuron " + name + " created! | " + Bias.ToString(), LogLevel_t.info);
        }
        #endregion


    }
}
