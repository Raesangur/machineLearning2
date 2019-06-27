using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using stdint;

namespace machineLearning2
{
    class Neuron_t
    {
        private machineLearning2 father;
        /* Public variables */
        public string name;
        public int column;
        public int line;
        public double bias = 0.0;
        public double output = 0.0;
        public double input = 0.0;

        public List<Connection_t> inputConnections = new List<Connection_t>();
        public List<Connection_t> outputConnections = new List<Connection_t>();

        #region Constructors
        public Neuron_t(machineLearning2 Parent, string Name)
        {
            father = Parent;
            name = Name;

            father.WriteLine("Neuron " + name + " created! | " + bias.ToString(), LogLevel_t.info);
        }

        public Neuron_t(machineLearning2 Parent, string Name, int Column, int Line)
        {
            father = Parent;
            name = Name;
            column = Column;
            line = Line;

            father.WriteLine("Neuron " + name + " created! | " + bias.ToString(), LogLevel_t.info);
        }

        public Neuron_t(machineLearning2 Parent, string Name, double Bias)
        {
            father = Parent;
            name = Name;
            bias = Bias;

            father.WriteLine("Neuron " + name + " created! | " + bias.ToString(), LogLevel_t.info);
        }

        public Neuron_t(machineLearning2 Parent, string Name, double Bias, double Input)
        {
            father = Parent;
            name = Name;
            bias = Bias;
            Input = input;

            father.WriteLine("Neuron " + name + " created! | " + bias.ToString(), LogLevel_t.info);
        }

        public Neuron_t(machineLearning2 Parent, string Name, double Bias, int Column, int Line)
        {
            father = Parent;
            name = Name;
            bias = Bias;
            column = Column;
            line = Line;

            father.WriteLine("Neuron " + name + " created! | " + bias.ToString(), LogLevel_t.info);
        }

        public Neuron_t(machineLearning2 Parent, string Name, double Bias, double Input, int Column, int Line)
        {
            father = Parent;
            name = Name;
            bias = Bias;
            Input = input;
            column = Column;
            line = Line;

            father.WriteLine("Neuron " + name + " created! | " + bias.ToString(), LogLevel_t.info);
        }
        #endregion

        public void addInputConnection(Connection_t Connection)
        {
            inputConnections.Add(Connection);
        }

        public void addOutputConnection(Connection_t Connection)
        {
            outputConnections.Add(Connection);
        }
    }
}
