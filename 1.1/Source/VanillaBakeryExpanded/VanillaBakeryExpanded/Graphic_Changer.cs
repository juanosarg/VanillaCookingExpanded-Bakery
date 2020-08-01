using RimWorld;
using Verse;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanillaBakeryExpanded
{
    public class Graphic_Changer: ThingWithComps
    {
        public bool doOnce = false;

        public override Graphic Graphic
        {
            get
            {
                if (!doOnce) {
                    System.Random rand = new System.Random();
                    if (rand.NextDouble() > 0.5)
                    {
                        //Log.Message("El grafico original");
                        doOnce = true;
                        return this.DefaultGraphic;
                    }
                    else
                    {
                       // Log.Message("El nuevo grafico");
                        Graphic newgraphic = GraphicDatabase.Get(typeof(Graphic_StackCount), "Things/Meals/VCE_OtherAlternate", this.def.graphicData.shaderType.Shader, this.def.graphicData.drawSize, this.DrawColor, this.DrawColorTwo);
                        doOnce = true;
                        return newgraphic;

                    } 

                }else{ return this.DefaultGraphic; }
                
              
            }
        }

       
    }
}
