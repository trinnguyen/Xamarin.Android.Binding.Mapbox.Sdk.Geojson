using System;
using Android.Runtime;

namespace Com.Mapbox.Geojson.Gson
{
    public partial class GeometryTypeAdapter
    {
        static IntPtr id_read_Lcom_google_gson_stream_JsonReader_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.geojson.gson']/class[@name='GeometryTypeAdapter']/method[@name='read' and count(parameter)=1 and parameter[1][@type='com.google.gson.stream.JsonReader']]"
        [Register("read", "(Lcom/google/gson/stream/JsonReader;)Lcom/mapbox/geojson/Geometry;", "GetRead_Lcom_google_gson_stream_JsonReader_Handler")]
        public override unsafe global::Java.Lang.Object Read(global::GoogleGson.Stream.JsonReader @in)
        {
            if (id_read_Lcom_google_gson_stream_JsonReader_ == IntPtr.Zero)
                id_read_Lcom_google_gson_stream_JsonReader_ = JNIEnv.GetMethodID(class_ref, "read", "(Lcom/google/gson/stream/JsonReader;)Lcom/mapbox/geojson/Geometry;");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(@in);

                global::Com.Mapbox.Geojson.IGeometry __ret;
                if (((object)this).GetType() == ThresholdType)
                    __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Geojson.IGeometry>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_read_Lcom_google_gson_stream_JsonReader_, __args), JniHandleOwnership.TransferLocalRef);
                else
                    __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Geojson.IGeometry>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "read", "(Lcom/google/gson/stream/JsonReader;)Lcom/mapbox/geojson/Geometry;"), __args), JniHandleOwnership.TransferLocalRef);
                return (Java.Lang.Object)__ret;
            }
            finally
            {
            }
        }

        static IntPtr id_write_Lcom_google_gson_stream_JsonWriter_Lcom_mapbox_geojson_Geometry_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.geojson.gson']/class[@name='GeometryTypeAdapter']/method[@name='write' and count(parameter)=2 and parameter[1][@type='com.google.gson.stream.JsonWriter'] and parameter[2][@type='com.mapbox.geojson.Geometry']]"
        [Register("write", "(Lcom/google/gson/stream/JsonWriter;Lcom/mapbox/geojson/Geometry;)V", "GetWrite_Lcom_google_gson_stream_JsonWriter_Lcom_mapbox_geojson_Geometry_Handler")]
        public override unsafe void Write(global::GoogleGson.Stream.JsonWriter @out, global::Java.Lang.Object value)
        {
            if (id_write_Lcom_google_gson_stream_JsonWriter_Lcom_mapbox_geojson_Geometry_ == IntPtr.Zero)
                id_write_Lcom_google_gson_stream_JsonWriter_Lcom_mapbox_geojson_Geometry_ = JNIEnv.GetMethodID(class_ref, "write", "(Lcom/google/gson/stream/JsonWriter;Lcom/mapbox/geojson/Geometry;)V");
            try
            {
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue(@out);
                __args[1] = new JValue(value);

                if (((object)this).GetType() == ThresholdType)
                    JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_write_Lcom_google_gson_stream_JsonWriter_Lcom_mapbox_geojson_Geometry_, __args);
                else
                    JNIEnv.CallNonvirtualVoidMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "write", "(Lcom/google/gson/stream/JsonWriter;Lcom/mapbox/geojson/Geometry;)V"), __args);
            }
            finally
            {
            }
        }
    }
}
