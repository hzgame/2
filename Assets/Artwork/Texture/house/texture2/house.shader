Shader "Unlit/house"
{
    Properties
    {
        _MainTex ("主贴图", 2D) = "white" {}
        _MetallicTex ("RGB:金属度贴图 A：粗糙度贴图", 2D) = "white" {}
        _RoughnessLevel ("粗糙度调节",range(0,5)) = 0.5
        //_OP("透明度",range(0,1)) = 0.5
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 100

        Pass
        {
            //Blend SrcAlpha OneMinusSrcAlpha
            cull off
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            // make fog work
            #pragma multi_compile_fog

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                UNITY_FOG_COORDS(1)
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;
            //float _OP;
            sampler2D _MetallicTex;
            half _RoughnessLevel;

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                UNITY_TRANSFER_FOG(o,o.vertex);
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                // sample the texture
                fixed4 col = tex2D(_MainTex, i.uv);
                fixed4 col1=tex2D(_MetallicTex,i.uv);
                half roughness=col1.a;
                col=col*roughness*_RoughnessLevel;
                // apply fog
                UNITY_APPLY_FOG(i.fogCoord, col);
                return col;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
}
