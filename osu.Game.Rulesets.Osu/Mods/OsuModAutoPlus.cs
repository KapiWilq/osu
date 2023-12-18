// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using System.Collections.Generic;
using System.Linq;
using osu.Game.Beatmaps;
using osu.Game.Rulesets.Mods;
using osu.Game.Rulesets.Osu.Replays;

namespace osu.Game.Rulesets.Osu.Mods
{
    public class OsuModAutoPlus : ModAutoPlus
    {
        public override Type[] IncompatibleMods => base.IncompatibleMods.Concat(new[] { typeof(OsuModAutoplay), typeof(OsuModAutopilot), typeof(OsuModMagnetised), typeof(OsuModRepel), typeof(OsuModSpunOut), typeof(OsuModAlternate), typeof(OsuModSingleTap) }).ToArray();

        public override ModReplayData CreateReplayData(IBeatmap beatmap, IReadOnlyList<Mod> mods)
            => new ModReplayData(new OsuAutoPlusGenerator(beatmap, mods).Generate(), new ModCreatedUser { Username = "Auto+" });
    }
}
