namespace TiledCS
{
    /// <summary>
    /// Represents an element within the Tilesets array of a TiledMap object
    /// </summary>
    public class TiledMapTileset
    {
        /// <summary>
        /// The first gid defines which gid matches the tile with source vector 0,0. Is used to determine which tileset belongs to which gid
        /// </summary>
        public int firstgid;
        /// <summary>
        /// The tsx file path as defined in the map file itself
        /// </summary>
        public string source;
    }

    /// <summary>
    /// Represents a property object in both tilesets, maps, layers and objects. Values are all in string but you can use the 'type' property for conversions
    /// </summary>
    public class TiledProperty
    {
        /// <summary>
        /// The property name or key in string format
        /// </summary>
        public string name;
        /// <summary>
        /// The property type as used in Tiled. Can be bool, number, string, ...
        /// </summary>
        public string type;
        /// <summary>
        /// The custom property type as used in Tiled 1.8+.
        /// </summary>
        public string propertytype;
        /// <summary>
        /// The value in string format
        /// </summary>
        public string value;
    }

    /// <summary>
    /// Represents a tile layer as well as an object layer within a tile map
    /// </summary>
    public class TiledLayer
    {
        /// <summary>
        /// The layer id
        /// </summary>
        public int id;
        /// <summary>
        /// The layer name
        /// </summary>
        public string name;
        /// <summary>
        /// The color used to display the objects in this group. (defaults to gray (“#a0a0a4”))
        /// </summary>
        public string color;
        /// <summary>
        /// Total horizontal tiles
        /// </summary>
        public int width;
        /// <summary>
        /// Total vertical tiles
        /// </summary>
        public int height;
        /// <summary>
        /// The layer type. Usually this is "objectgroup" or "tilelayer".
        /// </summary>
        public string type;
        /// <summary>
        /// The tint color set by the user in hex code
        /// </summary>
        public string tintcolor;
        /// <summary>
        /// Defines if the layer is visible in the editor
        /// </summary>
        public bool visible;
        /// <summary>
        /// Is true when the layer is locked
        /// </summary>
        public bool locked;
        /// <summary>
        /// The horizontal offset
        /// </summary>
        public double offsetX;
        /// <summary>
        /// The vertical offset
        /// </summary>
        public double offsetY;
        /// <summary>
        /// An int array of gid numbers which define which tile is being used where. The length of the array equals the layer width * the layer height. Is null when the layer is not a tilelayer.
        /// </summary>
        public TiledArray<int> data;
        /// <summary>
        /// A parallel array to data which stores the rotation flags of the tile.
        /// Bit 3 is horizontal flip,
        /// bit 2 is vertical flip, and
        /// bit 1 is (anti) diagonal flip.
        /// Is null when the layer is not a tilelayer.
        /// </summary>
        public TiledArray<byte> dataRotationFlags;
        /// <summary>
        /// The list of objects in case of an objectgroup layer. Is null when the layer has no objects.
        /// </summary>
        public TiledObject[] objects;
        /// <summary>
        /// The layer properties if set
        /// </summary>
        public TiledProperty[] properties;

        public TiledImage image;
    }

    /// <summary>
    /// Represents an tiled object defined in object layers
    /// </summary>
    public class TiledObject
    {
        /// <summary>
        /// The object id
        /// </summary>
        public int id;
        /// <summary>
        /// The object's name
        /// </summary>
        public string name;
        /// <summary>
        /// The object type if defined. Null if none was set.
        /// </summary>
        public string type;
        /// <summary>
        /// The object's x position in pixels
        /// </summary>
        public float x;
        /// <summary>
        /// The object's y position in pixels
        /// </summary>
        public float y;
        /// <summary>
        /// The rotation of the object in degrees clockwise around (x, y).
        /// </summary>
        public float rotation;
        /// <summary>
        /// The object's width in pixels
        /// </summary>
        public float width;
        /// <summary>
        /// The object's height in pixels
        /// </summary>
        public float height;
        /// <summary>
        /// The tileset gid when the object is linked to a tile
        /// </summary>
        public int gid;
        /// <summary>
        /// An array of properties. Is null if none were defined.
        /// </summary>
        public TiledProperty[] properties;
        /// <summary>
        /// The type of object. "tile" (has gid), "rectangle" (no gid), "point", "ellipse", "polygon", "polyline", "text".
        /// </summary>
        public string objectType;

        /// <summary>
        /// The parameters if the object is of type text.
        /// </summary>
        public TiledText text;

        /// <summary>
        /// The points if the object is of type polygon or polyline.
        /// </summary>
        public TiledPoint[] points;
    }

    public class TiledPoint {
        /// <summary>
        /// The x position in pixels
        /// </summary>
        public float x;
        /// <summary>
        /// The y position in pixels
        /// </summary>
        public float y;
    }

    public class TiledText {
        /// <summary>
        /// The text to display
        /// </summary>
        public string text;
        /// <summary>
        /// The font family used(defaults to “sans-serif”)
        /// </summary>
        public string fontfamily;
        /// <summary>
        ///  The size of the font in pixels(not using points, because other sizes in the TMX format are also using pixels) (defaults to 16)
        /// </summary>
        public int pixelsize;
        /// <summary>
        /// Whether word wrapping is enabled(1) or disabled(0). (defaults to 0)
        /// </summary>
        public bool wrap;
        /// <summary>
        /// Color of the text in #AARRGGBB or #RRGGBB format (defaults to #000000)
        /// </summary>
        public string color;
        /// <summary>
        /// Whether the font is bold(1) or not(0). (defaults to 0)
        /// </summary>
        public bool bold;
        /// <summary>
        /// Whether the font is italic(1) or not(0). (defaults to 0)
        /// </summary>
        public bool italic;
        /// <summary>
        /// Whether a line should be drawn below the text(1) or not(0). (defaults to 0)
        /// </summary>
        public bool underline;
        /// <summary>
        /// Whether a line should be drawn through the text(1) or not(0). (defaults to 0)
        /// </summary>
        public bool strikeout;
        /// <summary>
        /// Whether kerning should be used while rendering the text(1) or not(0). (defaults to 1)
        /// </summary>
        public bool kerning;
        /// <summary>
        /// Horizontal alignment of the text within the object (left, center, right or justify, defaults to left) (since Tiled 1.2.1)
        /// </summary>
        public string halign;
        /// <summary>
        /// Vertical alignment of the text within the object (top, center or bottom, defaults to top)
        /// </summary>
        public string valign;
    }

/// <summary>
/// Represents a tile within a tileset
/// </summary>
/// <remarks>These are not defined for all tiles within a tileset, only the ones with properties, terrains and animations.</remarks>
public class TiledTile
    {
        /// <summary>
        /// The tile id
        /// </summary>
        public int id;
        /// <summary>
        /// The custom tile type, set by the user
        /// </summary>
        public string type;
        /// <summary>
        /// The terrain definitions as int array. These are indices indicating what part of a terrain and which terrain this tile represents.
        /// </summary>
        /// <remarks>In the map file empty space is used to indicate null or no value. However, since it is an int array I needed something so I decided to replace empty values with -1.</remarks>
        public int[] terrain;
        /// <summary>
        /// An array of properties. Is null if none were defined.
        /// </summary>
        public TiledProperty[] properties;
        /// <summary>
        /// An array of tile animations. Is null if none were defined. 
        /// </summary>
        public TiledTileAnimation[] animation;
        /// <summary>
        /// The individual tile image
        /// </summary>
        public TiledImage image;
    }

    /// <summary>
    /// Represents an image
    /// </summary>
    public class TiledImage
    {
        /// <summary>
        /// The image width
        /// </summary>
        public int width;
        
        /// <summary>
        /// The image height
        /// </summary>
        public int height;
        
        /// <summary>
        /// The image source path
        /// </summary>
        public string source;
    }

    /// <summary>
    /// Represents a tile animation. Tile animations are a group of tiles which act as frames for an animation.
    /// </summary>
    public class TiledTileAnimation
    {
        /// <summary>
        /// The tile id within a tileset
        /// </summary>
        public int tileid;
        /// <summary>
        /// The duration in miliseconds
        /// </summary>
        public int duration;
    }

    /// <summary>
    /// Represents a terrain definition.
    /// </summary>
    public class TiledTerrain
    {
        /// <summary>
        /// The terrain name
        /// </summary>
        public string name;
        /// <summary>
        /// The tile used as icon for the terrain editor
        /// </summary>
        public int tile;
    }

    /// <summary>
    /// Used as data type for the GetSourceRect method. Represents basically a rectangle.
    /// </summary>
    public class TiledSourceRect
    {
        /// <summary>
        /// The x position in pixels from the tile location in the source image
        /// </summary>
        public int x;
        /// <summary>
        /// The y position in pixels from the tile location in the source image
        /// </summary>
        public int y;
        /// <summary>
        /// The width in pixels from the tile in the source image
        /// </summary>
        public int width;
        /// <summary>
        /// The height in pixels from the tile in the source image
        /// </summary>
        public int height;
    }

    /// <summary>
    /// Represents a layer or object group
    /// </summary>
    public class TiledGroup
    {
        /// <summary>
        /// The group's id
        /// </summary>
        public int id;
        /// <summary>
        /// The group's name
        /// </summary>
        public string name;
        /// <summary>
        /// The group's visibility
        /// </summary>
        public bool visible;
        /// <summary>
        /// The group's locked state
        /// </summary>
        public bool locked;
        /// <summary>
        /// The group's user properties
        /// </summary>
        public TiledProperty[] properties;
        /// <summary>
        /// The group's layers
        /// </summary>
        public TiledLayer[] layers;
        /// <summary>
        /// The group's objects
        /// </summary>
        public TiledObject[] objects;
        /// <summary>
        /// The group's subgroups
        /// </summary>
        public TiledGroup[] groups;
    }
}