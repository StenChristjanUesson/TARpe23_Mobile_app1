using Models;

namespace Services
{
    internal class PlanetsService
    {

        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the first planet from the Sun and the smallest " +
                "in the Solar System. In English, it is named after the ancient Roman god Mercurius " +
                "(Mercury), god of commerce and communication, and the messenger of the gods. " +
                "Mercury is classified as a terrestrial planet, with roughly the same surface gravity as Mars. " +
                "The surface of Mercury is heavily cratered, as a result of countless impact events " +
                "that have accumulated over billions of years.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/73_carousel_mercury_2.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/75_mercury_carousel_1.jpg"
                }
            },
            new()
            {
                Name = "Venus",
                Subtitle = "The pressure cooker",
                HeroImage = "venus.png",
                Description = "Venus is the second planet from the Sun. " +
                "It is a terrestrial planet and is the closest in mass and size to its orbital neighbour Earth. " +
                "Venus has by far the densest atmosphere of the terrestrial planets, " +
                "composed mostly of carbon dioxide with a thick, global sulfuric acid cloud cover. " +
                "At the surface it has a mean temperature of 737 K (464 °C; 867 °F) " +
                "and a pressure 92 times that of Earth's at sea level.",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/143_Venus-800x600.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/147_Hubble_Venus_Clouds-800x600.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/146_venus_carousel_3.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/144_PIA00485_Venus_Caldera-800.jpg"
                }
            },
            new()
            {
                Name = "Earth",
                Subtitle = "The cradle of life",
                HeroImage = "earth.png",
                Description = "The Earth is the only planet known where life exists. " +
                "Almost 1.5 million species of animals and plants have been discovered so far, " +
                "and many more have yet to be found. While other planets may have small amounts of ice or steam, " +
                "the Earth is 2/3 water. Earth has perfect conditions for a breathable atmosphere. ",
                AccentColorStart = Color.FromArgb("#0e3d68"),
                AccentColorEnd = Color.FromArgb("#2e97c7"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/68_epicearthmoonstill_800.png",
                    "https://solarsystem.nasa.gov/system/feature_items/images/69_earth_carousel_3.jpg",
                    "https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778"
                }
            },
            new()
            {
                Name = "Mars",
                Subtitle = "The red beauty",
                HeroImage = "mars.png",
                Description = "No planet has sparked the imaginations of humans as much " +
                "as Mars. It may be the reddish color of Mars, or the fact that it can " +
                "often be easily seen in the night sky, that has caused people to wonder " +
                "about this close neighbor of ours. Tales of “Martians” invading Earth " +
                "have been around for well over fifty years. But is it likely that any " +
                "kind of life really does exist on Mars? ",
                AccentColorStart = Color.FromArgb("#a23036"),
                AccentColorEnd = Color.FromArgb("#eb3333"),
                Images = new()
                {
                    "https://researchfdi.com/wp-content/uploads/2021/10/8944_1-PIA24546-1280.jpeg",
                    "https://www.worldatlas.com/r/w1300-q80/upload/bb/c3/32/shutterstock-1041249343.jpg",
                    "https://www.openaccessgovernment.org/wp-content/uploads/2021/04/dreamstime_xxl_121672573-scaled.jpg"
                }
            },
            new()
            {
                Name = "Jupiter",
                Subtitle = "The gas giant",
                HeroImage = "jupiter.png",
                Description = "Jupiter is the fifth planet from the Sun and the " +
                "largest in the Solar System. It is a gas giant with a mass more " +
                "than 2.5 times that of all the other planets in the Solar System " +
                "combined, and slightly less than one-thousandth the mass of the " +
                "Sun. Its diameter is eleven times that of Earth, and a tenth " +
                "that of the Sun. ",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/11_Full_Jupiter-800.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/10_Jupiter_Io_Juno-800.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/13_PIA24237_Jupiter_Cyclones-800.jpg"
                }
            },
            new()
            {
                Name = "Saturn",
                Subtitle = "The ring planet",
                HeroImage = "saturn.png",
                Description = "Saturn is the sixth planet from the Sun and " +
                            "the second-largest in the Solar System, after " +
                            "Jupiter. It is a gas giant with an average " +
                            "radius of about nine and a half times that " +
                            "of Earth. It has only one-eighth the average " +
                            "density of Earth, but is over 95 times more massive.",
                AccentColorStart = Color.FromArgb("#996237"),
                AccentColorEnd = Color.FromArgb("#c6502f"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/151_saturn_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/152_saturn_carousel_2.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/155_saturn_carousel_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/153_saturn_carousel_3.jpg"
                }
            },
            new()
            {
                Name = "Uranus",
                Subtitle = "The Herschel planet",
                HeroImage = "uranus.png",
                Description = "Uranus is the seventh planet from the Sun. " +
                            "It is named after Greek sky deity Uranus (Caelus), who in " +
                            "Greek mythology is the father of Cronus (Saturn), a grandfather " +
                            "of Zeus (Jupiter) and great-grandfather of Ares (Mars). Uranus " +
                            "has the third-largest planetary radius and fourth-largest " +
                            "planetary mass in the Solar System.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#996237"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/89_uranus_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg"
                }
            },
            new()
            {
                Name = "Neptune",
                Subtitle = "The god of the sea",
                HeroImage = "neptune.png",
                Description = "Neptune is the eighth planet from the Sun and " +
                            "the farthest known planet in the Solar System. It is the " +
                            "fourth-largest planet in the Solar System by diameter, the " +
                            "third-most-massive planet, and the densest giant planet. " +
                            "It is 17 times the mass of Earth, and slightly more " +
                            "massive than its near-twin Uranus.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/82_carousel_neptune_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/86_carousel_neptune_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/84_neptune_carousel_2.jpg"
                }
            },
            new()
            {
                Name = "Ceres",
                Subtitle = "The Quiet Dwarf Planet",
                HeroImage = "ceres.png",
                Description = "Ceres is a fascinating dwarf planet tucked away in the asteroid belt, " +
                "between Mars and Jupiter. It's like a frozen world of mystery, " +
                "with a surface full of bright salty spots and hints of water hiding beneath. " +
                "Once thought to be a planet, Ceres now holds its own as the largest object in the asteroid belt, " +
                "offering up clues about what might be lurking in the distant reaches of our solar system. " +
                "It's a quirky little world that keeps scientists guessing!",
                AccentColorStart = Color.FromArgb("#8b99a8"),
                AccentColorEnd = Color.FromArgb("#2F3D4A"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/7/76/Ceres_-_RC3_-_Haulani_Crater_%2822381131691%29_%28cropped%29.jpg",
                    "https://media.springernature.com/full/springer-static/image/art%3A10.1038%2Fs41550-024-02316-6/MediaObjects/41550_2024_2316_Fig1_HTML.png"
                }
            },
            new()
            {
                Name = "Pluto",
                Subtitle = "The Mysterious Dwarf Planet",
                HeroImage = "Pluto.jpg",
                Description = "Pluto is a small, icy world with a surface full of mystery and contrasts. " +
                "Its reddish-brown hues and icy plains give it a rugged, distant charm, " +
                "while its quirky orbit and unique features makes it " +
                "one of the most intriguing objects in the outer solar system.",
                AccentColorStart = Color.FromArgb("#975746"),
                AccentColorEnd = Color.FromArgb("#502D27"),
                Images = new()
                {
                    "https://images.newscientist.com/wp-content/uploads/2016/03/p_color2_enhanced_release_black_smaller.jpg?crop=1:1,smart&width=1200&height=1200&upscale=true",
                    "https://cff2.earth.com/uploads/2024/05/23193331/pluto_vast-hidden-ocean_surface_1m.jpg"
                }
            },
            new()
            {
                Name = "Haumea",
                Subtitle = "The Elongated Dwarf Planet",
                HeroImage = "Haumea.png",
                Description = "Haumea is a fast-spinning, egg-shaped dwarf planet with a frosty, " +
                "icy surface. Its unique elongated form and pale, icy hues give it a cool, " +
                "otherworldly vibe, reflecting the distant, " +
                "mysterious nature of the outer solar system.",
                AccentColorStart = Color.FromArgb("#AABED2"),
                AccentColorEnd = Color.FromArgb("#5F6E82"),
                Images = new()
                {
                    "https://i.natgeofe.com/n/fb94ecdc-c10e-4c2e-bbdd-1c549ada89a3/01-ring-dwarf-planet-haumea-neptune.jpg",
                    "https://science.nasa.gov/wp-content/uploads/2023/07/haumea-480x320-1-jpg.webp?w=320"
                }
            },
            new()
            {
                Name = "Makemake",
                Subtitle = "The Distant Dwarf Planet",
                HeroImage = "makemake.png",
                Description = "Makemake is a cold, distant dwarf planet with a surface " +
                "that's a mix of icy frost and reddish-brown hues. " +
                "Far out in the solar system, it holds a quiet, mysterious beauty, " +
                "blending earthy tones with the chill of the outer reaches.",
                AccentColorStart = Color.FromArgb("#9E5E44"),
                AccentColorEnd = Color.FromArgb("#533324"),
                Images = new()
                {
                    "https://cdn.mos.cms.futurecdn.net/8QBGiy9BhmttKdGeAAZpn8.jpg",
                    "https://science.nasa.gov/wp-content/uploads/2023/04/makemakemoon100mile-jpg.webp?w=2000"
                }
            },
            new()
            {
                Name = "Eris",
                Subtitle = "The Frozen Dwarf Planet",
                HeroImage = "Eris.jpg",
                Description = "Eris is a distant and mysterious dwarf planet, " +
                "draped in icy, rocky surfaces with a hint of reddish-brown. " +
                "It’s a world far from the Sun, where shadowed, " +
                "dark hues blend with subtle hints of warmth, " +
                "creating a unique and cool vibe in the outer solar system.",
                AccentColorStart = Color.FromArgb("#8A6B5F"),
                AccentColorEnd = Color.FromArgb("#3C2D27"),
                Images = new()
                {
                    "https://assets.science.nasa.gov/dynamicimage/assets/science/psd/solar/internal_resources/3256/Artists_c_oncept_of_Eris_and_Dysnomia_far_from_the_Sun.jpeg?w=800&h=600&fit=clip&crop=faces%2Cfocalpoint",
                    "https://cdn.britannica.com/18/127118-050-346C260E/Eris-right-artist-Sun-rendering.jpg"
                }
            },
        };

        public static List<Planet> GetFeaturedPlanets()
        {
            var random = new Random();
            var randomizePlanets = planets
                .OrderBy(item => random.Next());

            return randomizePlanets
                .Take(2)
                .ToList();
        }

        public static List<Planet> GetAllPlanets()
            => planets;
    }
}