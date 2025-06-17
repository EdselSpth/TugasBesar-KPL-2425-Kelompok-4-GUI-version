using System.Collections.Generic;
using System.Linq;

namespace LoginAPI.Models
{
    public class StateBasedAuth
    {
        // Kelas untuk menyimpan data transisi state
        public class Transition
        {
            public LoginState From { get; set; }     // State awal
            public LoginState To { get; set; }       // State tujuan
            public LoginTrigger Trigger { get; set; } // Trigger untuk pindah state

            public Transition(LoginState from, LoginState to, LoginTrigger trigger)
            {
                From = from;
                To = to;
                Trigger = trigger;
            }
        }

        // Daftar semua transisi yang valid
        public static readonly List<Transition> transitions = new()
        {
            new Transition(LoginState.Awal, LoginState.Validasi, LoginTrigger.Submit),
            new Transition(LoginState.Validasi, LoginState.Berhasil, LoginTrigger.Valid),
            new Transition(LoginState.Validasi, LoginState.Gagal, LoginTrigger.Invalid),
        };

        // Fungsi untuk menentukan state berikutnya
        public static LoginState GetNextState(LoginState currentState, LoginTrigger trigger)
        {
            // Cari transisi yang sesuai dengan state dan trigger
            var transition = transitions.FirstOrDefault(t => t.From == currentState && t.Trigger == trigger);

            // Jika ada transisi, kembalikan state tujuan; jika tidak, tetap di state sekarang
            return transition != null ? transition.To : currentState;
        }
    }
}
