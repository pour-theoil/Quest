

namespace Quest
{
    public class Hat
    {
    public int ShininessLevel { get; set; }
    
    public string ShininessDescription()
    {
        if (ShininessLevel < 2){
            return "dull";
        }

        if (ShininessLevel> 1 && ShininessLevel <6){
            return "noticable";
        }
        if (ShininessLevel> 5 && ShininessLevel <10){
            return "bright";
        }
        else
        {
            return "blinding";
        }
    }

        
    }
}