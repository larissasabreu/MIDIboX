using NAudio.Midi;

// This class listens for MIDI input
public class MidiListener
{
    private MidiIn midiIn;
    private HitboxMapper mapper;

    public MidiListener(HitboxMapper mapper)
    {
        this.mapper = mapper;
        midiIn = new MidiIn(0); // First MIDI input device
        midiIn.MessageReceived += OnMidiMessage;
    }

    public void Start()
    {
        midiIn.Start();
    }

    private void OnMidiMessage(object sender, MidiInMessageEventArgs e)
    {
        if (e.MidiEvent is NoteEvent noteEvent)
        {
            bool pressed = noteEvent.CommandCode == MidiCommandCode.NoteOn && noteEvent.Velocity > 0;
            mapper.HandleNote(noteEvent.NoteNumber, pressed);
        }
    }
}


