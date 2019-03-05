// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Game.Beatmaps.Drawables;

namespace osu.Game.Screens.Multi.Components
{
    public class MultiplayerBackgroundSprite : MultiplayerComposite
    {
        [BackgroundDependencyLoader]
        private void load()
        {
            UpdateableBeatmapBackgroundSprite sprite;

            InternalChild = sprite = CreateBackgroundSprite();

            CurrentItem.BindValueChanged(item => sprite.Beatmap.Value = item.NewValue?.Beatmap, true);
        }

        protected virtual UpdateableBeatmapBackgroundSprite CreateBackgroundSprite() => new UpdateableBeatmapBackgroundSprite { RelativeSizeAxes = Axes.Both };
    }
}
