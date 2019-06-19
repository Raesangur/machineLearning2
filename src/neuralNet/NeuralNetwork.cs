using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace machineLearning2
{
    class NeuralNetwork_t
    {
        private machineLearning2 father;
        public string name;

        public List<List<Neuron_t>> neuronsList = new List<List<Neuron_t>>();
        public List<List<Connection_t>> connectionsList = new List<List<Connection_t>>();

        public NeuralNetwork_t(machineLearning2 Parent, string Name)
        {
            father = Parent;
            name = Name;

            father.WriteLine("Neural Network " + name + " created! | ", LogLevel_t.info);
        }

        public void addNeuron(Neuron_t Neuron, uint16_t Column)
        {
            if (Column - 1 > neuronsList.Count)
            {
                father.WriteLine("Column out of range", LogLevel_t.error);
                return;
            }
            neuronsList[Column].Add(Neuron);
        }

        public void addConnection(Connection_t Connection, uint16_t Column)
        {
            if (Column - 1 > connectionsList.Add(Connection))
            {
                
            }
        }
    }
}
