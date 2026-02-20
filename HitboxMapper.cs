using Nefarius.ViGEm.Client.Targets;
using Nefarius.ViGEm.Client.Targets.Xbox360;

public class HitboxMapper
{
    private IXbox360Controller controller;

    public HitboxMapper(IXbox360Controller controller)
    {
        this.controller = controller;
    }

    public void HandleNote(int note, bool pressed)
    {
        switch (note)
        {
            // D-Pad
            // SWING+
            case 72: controller.SetButtonState(Xbox360Button.Left, pressed); break;
            // SWING-
            case 73: controller.SetButtonState(Xbox360Button.Down, pressed); break;
            // TEMPO+
            case 74: controller.SetButtonState(Xbox360Button.Right, pressed); break;
            // TEMPO-
            case 75: controller.SetButtonState(Xbox360Button.Up, pressed); break;


            // ABXY
            // PAD 5
            case 36: controller.SetButtonState(Xbox360Button.A, pressed); break;
            // PAD 7
            case 38: controller.SetButtonState(Xbox360Button.B, pressed); break;
            // PAD 1
            case 40: controller.SetButtonState(Xbox360Button.X, pressed); break;
            //PAD 2
            case 41: controller.SetButtonState(Xbox360Button.Y, pressed); break;
        }
    }
}

