using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace machineLearning2.src.neuralNet
{
    class NeuralNetwork_t
    {
        public List<List<Neuron_t>> neurons = new List<List<Neuron_t>>();
        public List<List<Connection_t>> connections = new List<List<Connection_t>>();

        public NeuralNetwork_t() { }

        public void addNeuron(Neuron_t Neuron, uint16_t Column)
        {
            if (Column - 1 > neurons.Count)
            {

            }
        }
    }
}
