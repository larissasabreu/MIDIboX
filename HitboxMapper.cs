using Nefarius.ViGEm.Client.Targets;
using Nefarius.ViGEm.Client.Targets.Xbox360;

// This class maps MIDI notes to Xbox 360 controller inputs
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
            // I'm using M-VAVE SMK-25
            // The notes changes with transposition
            // So if it is +2:

            // D-Pad
            // C
            case 72: 
                controller.SetButtonState(Xbox360Button.Left, pressed); 
                break;
            // C#
            case 73: 
                controller.SetButtonState(Xbox360Button.Down, pressed); 
                break;
            // D
            case 74: 
                controller.SetButtonState(Xbox360Button.Right, pressed); 
                break;
            // D#
            case 75: 
                controller.SetButtonState(Xbox360Button.Up, pressed); 
                break;


            //// ABXY
            //// Using the pads is easier but less funny
            //// PAD 5
            //case 36: controller.SetButtonState(Xbox360Button.A, pressed); break;
            //// PAD 6
            //case 37: controller.SetButtonState(Xbox360Button.B, pressed); break;
            //// PAD 1
            //case 40: controller.SetButtonState(Xbox360Button.X, pressed); break;
            ////PAD 2
            //case 41: controller.SetButtonState(Xbox360Button.Y, pressed); break;

            // ABXY
            // Using the other notes as ABXY
            // TRIAD
            case 89: controller.SetButtonState(Xbox360Button.A, pressed); 
                break;
            // 7TH
            case 90: controller.SetButtonState(Xbox360Button.B, pressed); 
                break;
            // 9TH
            case 91: controller.SetButtonState(Xbox360Button.X, pressed); 
                break;
            // RAND
            case 92: controller.SetButtonState(Xbox360Button.Y, pressed); 
                break;

            //LB RB LT RT
            // PAD 4
            case 43:
                controller.SetSliderValue(Xbox360Slider.LeftTrigger, pressed ? (byte)255 : (byte)0);
                break;
            // PAD 8
            case 39:
                controller.SetSliderValue(Xbox360Slider.RightTrigger, pressed ? (byte)255 : (byte)0);
                break;

            // PAD 7
            case 38:
                controller.SetButtonState(Xbox360Button.RightShoulder, pressed); 
                break;
            // PAD 3
            case 42:
                controller.SetButtonState(Xbox360Button.LeftThumb, pressed); 
                break;

            //Start & Select
            // PAD 1
            case 40:
                controller.SetButtonState(Xbox360Button.Start, pressed); 
                break;
            // PAD 5
            case 36:
                controller.SetButtonState(Xbox360Button.Back, pressed); 
                break;
        }
    }
}

