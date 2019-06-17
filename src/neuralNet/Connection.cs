using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace machineLearning2
{
    class Connection_t
    {
        private machineLearning2 father;
        /* Public Variables */
        public string name;
        public double weight = 1.0;

        public Neuron_t inputNeuron;
        public Neuron_t outputNeuron;

        #region Constructors
        public Connection_t(machineLearning2 Parent, string Name, Neuron_t NeuronIn, Neuron_t NeuronOut)
        {
            father = Parent;
            name = Name;
            inputNeuron = NeuronIn;
            outputNeuron = NeuronOut;

            inputNeuron.addOutputConnection(this);
            outputNeuron.addInputConnection(this);
        }

        public Connection_t(machineLearning2 Parent, string Name, Neuron_t NeuronIn, Neuron_t NeuronOut, double Weight)
        {
            father = Parent;
            name = Name;
            inputNeuron = NeuronIn;
            outputNeuron = NeuronOut;
            weight = Weight;

            inputNeuron.addOutputConnection(this);
            outputNeuron.addInputConnection(this);
        }
        #endregion
    }
}
