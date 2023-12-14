using PipesInPool.Model;
using PipesInPool.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipesInPool.Controlles
{
    class PoolController
    {
        Pool myPool = new Pool();
        Display myDisplay = new Display();

        public PoolController()
        {
            
            myDisplay.Input(); // vhod
            
            // prehvurlq ot Display kum Pool 
            myPool.Volume = myDisplay.Volume;
            myPool.PipeFlow1 = myDisplay.Pipe1Flow;
            myPool.PipeFlow2 = myDisplay.Pipe2Flow;
            myPool.Hours = myDisplay.Hours;
            

            // calculacii i prisvoqvane 
            myDisplay.IfThePoolOverFlows = myPool.PrintIfOverFlows(); 

            //izhod
            myDisplay.Output();



        }

    }
}
