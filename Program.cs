using System;
using Nefarius.ViGEm.Client;

class Program
{
    static void Main()
    {
        var vigem = new ViGEmClient();
        var controller = vigem.CreateXbox360Controller();
        controller.Connect();

        Console.WriteLine("Virtual Controller CONNECTED");

        var mapper = new HitboxMapper(controller);
        var midi = new MidiListener(mapper);

        midi.Start();

        Console.WriteLine("MIDI Hitbox ON");
        Console.ReadLine();

        controller.Disconnect();
    }
}

