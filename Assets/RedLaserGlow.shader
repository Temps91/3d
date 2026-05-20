Shader "Custom/RedLaserGlow"
{
    Properties
    {
        _Color ("Laser Color", Color) = (1,0,0,1)
        _EmissionStrength ("Emission Strength", Range(0,10)) = 3
    }

    SubShader
    {
        Tags { "RenderType"="Opaque" }

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
            };

            struct v2f
            {
                float4 vertex : SV_POSITION;
            };

            fixed4 _Color;
            float _EmissionStrength;

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                return _Color * _EmissionStrength;
            }
            ENDCG
        }
    }
}