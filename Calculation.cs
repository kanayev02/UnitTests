using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSUniversalLib

{
    public class Calculation
    {
        public int GetPriorityForAgent(int agentType, float age, float experience)
        {
            int priorityGeneral;
            float priority;
            float agentk;
            if (age<=25&&experience<=3)
            {
                switch(agentType)
                {
                    case 1:
                        {
                            priority = (float)(experience * 1.9);
                            priorityGeneral = (int)Math.Round(priority);
                            return priorityGeneral;
                            
                        }
                    case 2:
                        {
                            priority = (float)(experience * 3.37);
                            priorityGeneral = (int)Math.Round(priority);
                            return priorityGeneral;
                        }
                    case 3:
                        {
                            priority = (float)(experience * 4.36);
                            priorityGeneral = (int)Math.Round(priority);
                            return priorityGeneral;
                        }
                    default:
                        {
                            return -1;
                        }
                }
            }
            else
            { 
                switch (agentType)
                {
                    case 1:
                        {
                            
                            if (experience > 10 && experience <= 20)
                            {
                                agentk = (float)2.3;
                                priority = experience * agentk;
                                priorityGeneral = (int)Math.Round(priority);
                                return priorityGeneral;
                            }
                            else if (experience > 20 && experience < 40) 
                            {
                                agentk = (float)2.5;
                                priority = experience * agentk;
                                priorityGeneral = (int)Math.Round(priority);
                                return priorityGeneral;
                            }
                            else if (experience >= 40) 
                            { 
                                agentk = (float)2.7;
                                priority = experience * agentk;
                                priorityGeneral = (int)Math.Round(priority);
                                return priorityGeneral;
                            }
                            break;
                        }
                    case 2:
                        {
                            if (experience > 10 && experience <= 20)
                            {
                                agentk = (float)3.7;
                                priority = experience * agentk;
                                priorityGeneral = (int)Math.Round(priority);
                                return priorityGeneral;
                            }
                            else if (experience > 20 && experience < 40)
                            {
                                agentk = (float)3.9;
                                priority = experience * agentk;
                                priorityGeneral = (int)Math.Round(priority);
                                return priorityGeneral;
                            }
                            else if (experience >= 40)
                            {
                                agentk = (float)4.1;
                                priority = experience * agentk;
                                priorityGeneral = (int)Math.Round(priority);
                                return priorityGeneral;
                            }
                            break;
                        }
                    case 3:
                        {
                            if (experience > 10 && experience <= 20)
                            {
                                agentk = (float)4.6;
                                priority = experience * agentk;
                                priorityGeneral = (int)Math.Round(priority);
                                return priorityGeneral;
                            }
                            else if (experience > 20 && experience < 40)
                            {
                                agentk = (float)4.8;
                                priority = experience * agentk;
                                priorityGeneral = (int)Math.Round(priority);
                                return priorityGeneral;
                            }
                            else if (experience >= 40)
                            {
                                agentk = (float)5;
                                priority = experience * agentk;
                                priorityGeneral = (int)Math.Round(priority);
                                return priorityGeneral;
                            }
                            break;
                        }
                    default:
                        {
                            return -1;
                        }
                }
                return -1;
            }
            
        }
    }
}
