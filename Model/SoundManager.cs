using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Application.Model
{
     public class SoundManager
    { 
        public static void GetAllSounds(ObservableCollection<Sound> sounds)
        {
            var allSounds = getSounds();
            sounds.Clear();
            allSounds.ForEach(p => sounds.Add(p));

        }

        public static void GetSoundsCategory (ObservableCollection<Sound> sounds, SoundCategory soundCategory)
        {
            var allSounds = getSounds();
            var filteredSounds = allSounds.Where(p => p.Category == soundCategory).ToList();
            sounds.Clear();
            filteredSounds.ForEach(p => sounds.Add(p));
        }
        private static List<Sound> getSounds()
        {
            var sounds = new List<Sound>();
            sounds.Add(new Sound("Cow", SoundCategory.Animals));
            sounds.Add(new Sound("Cat", SoundCategory.Animals));
            sounds.Add(new Sound("gun", SoundCategory.Cartoors));
            sounds.Add(new Sound("spring", SoundCategory.Cartoors));
            sounds.Add(new Sound("Clock", SoundCategory.Taunts));
            sounds.Add(new Sound("LOl", SoundCategory.Taunts));
            sounds.Add(new Sound("Ship", SoundCategory.Warnings));
            sounds.Add(new Sound("Siren", SoundCategory.Warnings));
            return sounds;
                                     
        }
            }
}
