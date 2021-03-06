namespace Azure.Core
{
    public partial class JsonObjectSerializer : Azure.Core.ObjectSerializer
    {
        public JsonObjectSerializer() { }
        public JsonObjectSerializer(System.Text.Json.JsonSerializerOptions options) { }
        public override object Deserialize(System.IO.Stream stream, System.Type returnType) { throw null; }
        public override System.Threading.Tasks.ValueTask<object> DeserializeAsync(System.IO.Stream stream, System.Type returnType) { throw null; }
        public override void Serialize(System.IO.Stream stream, object? value, System.Type inputType) { }
        public override System.Threading.Tasks.ValueTask SerializeAsync(System.IO.Stream stream, object? value, System.Type inputType) { throw null; }
    }
    public abstract partial class ObjectSerializer
    {
        protected ObjectSerializer() { }
        public abstract object Deserialize(System.IO.Stream stream, System.Type returnType);
        public abstract System.Threading.Tasks.ValueTask<object> DeserializeAsync(System.IO.Stream stream, System.Type returnType);
        public abstract void Serialize(System.IO.Stream stream, object? value, System.Type inputType);
        public abstract System.Threading.Tasks.ValueTask SerializeAsync(System.IO.Stream stream, object? value, System.Type inputType);
    }
}
namespace Azure.Core.Spatial
{
    public sealed partial class CollectionGeometry : Azure.Core.Spatial.Geometry
    {
        public CollectionGeometry(System.Collections.Generic.IEnumerable<Azure.Core.Spatial.Geometry> geometries) : base (default(Azure.Core.Spatial.GeometryProperties)) { }
        public CollectionGeometry(System.Collections.Generic.IEnumerable<Azure.Core.Spatial.Geometry> geometries, Azure.Core.Spatial.GeometryProperties properties) : base (default(Azure.Core.Spatial.GeometryProperties)) { }
        public System.Collections.Generic.IReadOnlyList<Azure.Core.Spatial.Geometry> Geometries { get { throw null; } }
    }
    public partial class Geometry
    {
        protected Geometry(Azure.Core.Spatial.GeometryProperties properties) { }
        public Azure.Core.Spatial.GeometryProperties Properties { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct GeometryBoundingBox : System.IEquatable<Azure.Core.Spatial.GeometryBoundingBox>
    {
        private readonly int _dummyPrimitive;
        public GeometryBoundingBox(double west, double south, double east, double north) { throw null; }
        public GeometryBoundingBox(double west, double south, double east, double north, double? minAltitude, double? maxAltitude) { throw null; }
        public double East { get { throw null; } }
        public double? MaxAltitude { get { throw null; } }
        public double? MinAltitude { get { throw null; } }
        public double North { get { throw null; } }
        public double South { get { throw null; } }
        public double West { get { throw null; } }
        public bool Equals(Azure.Core.Spatial.GeometryBoundingBox other) { throw null; }
        public override bool Equals(object? obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public partial class GeometryJsonConverter : System.Text.Json.Serialization.JsonConverter<Azure.Core.Spatial.Geometry>
    {
        public GeometryJsonConverter() { }
        public override Azure.Core.Spatial.Geometry Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options) { throw null; }
        public override void Write(System.Text.Json.Utf8JsonWriter writer, Azure.Core.Spatial.Geometry value, System.Text.Json.JsonSerializerOptions options) { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct GeometryPosition : System.IEquatable<Azure.Core.Spatial.GeometryPosition>
    {
        private readonly int _dummyPrimitive;
        public GeometryPosition(double longitude, double latitude) { throw null; }
        public GeometryPosition(double longitude, double latitude, double? altitude) { throw null; }
        public double? Altitude { get { throw null; } }
        public double Latitude { get { throw null; } }
        public double Longitude { get { throw null; } }
        public bool Equals(Azure.Core.Spatial.GeometryPosition other) { throw null; }
        public override bool Equals(object? obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Core.Spatial.GeometryPosition left, Azure.Core.Spatial.GeometryPosition right) { throw null; }
        public static bool operator !=(Azure.Core.Spatial.GeometryPosition left, Azure.Core.Spatial.GeometryPosition right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class GeometryProperties
    {
        public GeometryProperties(Azure.Core.Spatial.GeometryBoundingBox? boundingBox = default(Azure.Core.Spatial.GeometryBoundingBox?), System.Collections.Generic.IReadOnlyDictionary<string, object?>? additionalProperties = null) { }
        public System.Collections.Generic.IReadOnlyDictionary<string, object?> AdditionalProperties { get { throw null; } }
        public Azure.Core.Spatial.GeometryBoundingBox? BoundingBox { get { throw null; } }
    }
    public sealed partial class LineGeometry : Azure.Core.Spatial.Geometry
    {
        public LineGeometry(System.Collections.Generic.IEnumerable<Azure.Core.Spatial.GeometryPosition> positions) : base (default(Azure.Core.Spatial.GeometryProperties)) { }
        public LineGeometry(System.Collections.Generic.IEnumerable<Azure.Core.Spatial.GeometryPosition> positions, Azure.Core.Spatial.GeometryProperties properties) : base (default(Azure.Core.Spatial.GeometryProperties)) { }
        public System.Collections.Generic.IReadOnlyList<Azure.Core.Spatial.GeometryPosition> Positions { get { throw null; } }
    }
    public sealed partial class MultiLineGeometry : Azure.Core.Spatial.Geometry
    {
        public MultiLineGeometry(System.Collections.Generic.IEnumerable<Azure.Core.Spatial.LineGeometry> lines) : base (default(Azure.Core.Spatial.GeometryProperties)) { }
        public MultiLineGeometry(System.Collections.Generic.IEnumerable<Azure.Core.Spatial.LineGeometry> lines, Azure.Core.Spatial.GeometryProperties properties) : base (default(Azure.Core.Spatial.GeometryProperties)) { }
        public System.Collections.Generic.IReadOnlyList<Azure.Core.Spatial.LineGeometry> Lines { get { throw null; } }
    }
    public sealed partial class MultiPointGeometry : Azure.Core.Spatial.Geometry
    {
        public MultiPointGeometry(System.Collections.Generic.IEnumerable<Azure.Core.Spatial.PointGeometry> points) : base (default(Azure.Core.Spatial.GeometryProperties)) { }
        public MultiPointGeometry(System.Collections.Generic.IEnumerable<Azure.Core.Spatial.PointGeometry> points, Azure.Core.Spatial.GeometryProperties properties) : base (default(Azure.Core.Spatial.GeometryProperties)) { }
        public System.Collections.Generic.IReadOnlyList<Azure.Core.Spatial.PointGeometry> Points { get { throw null; } }
    }
    public sealed partial class MultiPolygonGeometry : Azure.Core.Spatial.Geometry
    {
        public MultiPolygonGeometry(System.Collections.Generic.IEnumerable<Azure.Core.Spatial.PolygonGeometry> polygons) : base (default(Azure.Core.Spatial.GeometryProperties)) { }
        public MultiPolygonGeometry(System.Collections.Generic.IEnumerable<Azure.Core.Spatial.PolygonGeometry> polygons, Azure.Core.Spatial.GeometryProperties properties) : base (default(Azure.Core.Spatial.GeometryProperties)) { }
        public System.Collections.Generic.IReadOnlyList<Azure.Core.Spatial.PolygonGeometry> Polygons { get { throw null; } }
    }
    public sealed partial class PointGeometry : Azure.Core.Spatial.Geometry
    {
        public PointGeometry(Azure.Core.Spatial.GeometryPosition position) : base (default(Azure.Core.Spatial.GeometryProperties)) { }
        public PointGeometry(Azure.Core.Spatial.GeometryPosition position, Azure.Core.Spatial.GeometryProperties properties) : base (default(Azure.Core.Spatial.GeometryProperties)) { }
        public Azure.Core.Spatial.GeometryPosition Position { get { throw null; } }
    }
    public sealed partial class PolygonGeometry : Azure.Core.Spatial.Geometry
    {
        public PolygonGeometry(System.Collections.Generic.IEnumerable<Azure.Core.Spatial.LineGeometry> rings) : base (default(Azure.Core.Spatial.GeometryProperties)) { }
        public PolygonGeometry(System.Collections.Generic.IEnumerable<Azure.Core.Spatial.LineGeometry> rings, Azure.Core.Spatial.GeometryProperties properties) : base (default(Azure.Core.Spatial.GeometryProperties)) { }
        public System.Collections.Generic.IReadOnlyList<Azure.Core.Spatial.LineGeometry> Rings { get { throw null; } }
    }
}
