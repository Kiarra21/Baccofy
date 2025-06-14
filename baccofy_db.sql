PGDMP      )                }            baccofy2    16.2    16.2 3               0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false                       0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false                        1262    20407    baccofy2    DATABASE        CREATE DATABASE baccofy2 WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_Indonesia.1252';
    DROP DATABASE baccofy2;
                postgres    false            �            1259    20416    akun    TABLE     �   CREATE TABLE public.akun (
    id_akun integer NOT NULL,
    username character varying(20) NOT NULL,
    nomor_telepon character varying(20) NOT NULL,
    role_id_role integer NOT NULL,
    password character varying(8) NOT NULL
);
    DROP TABLE public.akun;
       public         heap    postgres    false            �            1259    20415    akun_id_akun_seq    SEQUENCE     �   CREATE SEQUENCE public.akun_id_akun_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 '   DROP SEQUENCE public.akun_id_akun_seq;
       public          postgres    false    218            !           0    0    akun_id_akun_seq    SEQUENCE OWNED BY     E   ALTER SEQUENCE public.akun_id_akun_seq OWNED BY public.akun.id_akun;
          public          postgres    false    217            �            1259    20428    bahan    TABLE     �   CREATE TABLE public.bahan (
    id_bahan integer NOT NULL,
    nama_bahan character varying(50) NOT NULL,
    keterangan character varying(50) NOT NULL
);
    DROP TABLE public.bahan;
       public         heap    postgres    false            �            1259    20427    bahan_id_bahan_seq    SEQUENCE     �   CREATE SEQUENCE public.bahan_id_bahan_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public.bahan_id_bahan_seq;
       public          postgres    false    220            "           0    0    bahan_id_bahan_seq    SEQUENCE OWNED BY     I   ALTER SEQUENCE public.bahan_id_bahan_seq OWNED BY public.bahan.id_bahan;
          public          postgres    false    219            �            1259    20447    detail_pencatatan    TABLE     �   CREATE TABLE public.detail_pencatatan (
    id_detail integer NOT NULL,
    quantity integer NOT NULL,
    keterangan character varying(50),
    pencatatan_id_pencatatan integer NOT NULL,
    bahan_id_bahan integer NOT NULL
);
 %   DROP TABLE public.detail_pencatatan;
       public         heap    postgres    false            �            1259    20446    detail_pencatatan_id_detail_seq    SEQUENCE     �   CREATE SEQUENCE public.detail_pencatatan_id_detail_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 6   DROP SEQUENCE public.detail_pencatatan_id_detail_seq;
       public          postgres    false    224            #           0    0    detail_pencatatan_id_detail_seq    SEQUENCE OWNED BY     c   ALTER SEQUENCE public.detail_pencatatan_id_detail_seq OWNED BY public.detail_pencatatan.id_detail;
          public          postgres    false    223            �            1259    20464    gaji_petani    TABLE     �   CREATE TABLE public.gaji_petani (
    id_gaji integer NOT NULL,
    tanggal date NOT NULL,
    nominal numeric NOT NULL,
    keterangan character varying(50),
    akun_id_akun integer NOT NULL
);
    DROP TABLE public.gaji_petani;
       public         heap    postgres    false            �            1259    20463    gaji_petani_id_gaji_seq    SEQUENCE     �   CREATE SEQUENCE public.gaji_petani_id_gaji_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 .   DROP SEQUENCE public.gaji_petani_id_gaji_seq;
       public          postgres    false    226            $           0    0    gaji_petani_id_gaji_seq    SEQUENCE OWNED BY     S   ALTER SEQUENCE public.gaji_petani_id_gaji_seq OWNED BY public.gaji_petani.id_gaji;
          public          postgres    false    225            �            1259    20435 
   pencatatan    TABLE     �   CREATE TABLE public.pencatatan (
    id_pencatatan integer NOT NULL,
    tanggal date NOT NULL,
    akun_id_akun integer NOT NULL
);
    DROP TABLE public.pencatatan;
       public         heap    postgres    false            �            1259    20434    pencatatan_id_pencatatan_seq    SEQUENCE     �   CREATE SEQUENCE public.pencatatan_id_pencatatan_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 3   DROP SEQUENCE public.pencatatan_id_pencatatan_seq;
       public          postgres    false    222            %           0    0    pencatatan_id_pencatatan_seq    SEQUENCE OWNED BY     ]   ALTER SEQUENCE public.pencatatan_id_pencatatan_seq OWNED BY public.pencatatan.id_pencatatan;
          public          postgres    false    221            �            1259    20409    role    TABLE     i   CREATE TABLE public.role (
    id_role integer NOT NULL,
    nama_role character varying(10) NOT NULL
);
    DROP TABLE public.role;
       public         heap    postgres    false            �            1259    20408    role_id_role_seq    SEQUENCE     �   CREATE SEQUENCE public.role_id_role_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 '   DROP SEQUENCE public.role_id_role_seq;
       public          postgres    false    216            &           0    0    role_id_role_seq    SEQUENCE OWNED BY     E   ALTER SEQUENCE public.role_id_role_seq OWNED BY public.role.id_role;
          public          postgres    false    215            j           2604    20419    akun id_akun    DEFAULT     l   ALTER TABLE ONLY public.akun ALTER COLUMN id_akun SET DEFAULT nextval('public.akun_id_akun_seq'::regclass);
 ;   ALTER TABLE public.akun ALTER COLUMN id_akun DROP DEFAULT;
       public          postgres    false    218    217    218            k           2604    20431    bahan id_bahan    DEFAULT     p   ALTER TABLE ONLY public.bahan ALTER COLUMN id_bahan SET DEFAULT nextval('public.bahan_id_bahan_seq'::regclass);
 =   ALTER TABLE public.bahan ALTER COLUMN id_bahan DROP DEFAULT;
       public          postgres    false    220    219    220            m           2604    20450    detail_pencatatan id_detail    DEFAULT     �   ALTER TABLE ONLY public.detail_pencatatan ALTER COLUMN id_detail SET DEFAULT nextval('public.detail_pencatatan_id_detail_seq'::regclass);
 J   ALTER TABLE public.detail_pencatatan ALTER COLUMN id_detail DROP DEFAULT;
       public          postgres    false    224    223    224            n           2604    20467    gaji_petani id_gaji    DEFAULT     z   ALTER TABLE ONLY public.gaji_petani ALTER COLUMN id_gaji SET DEFAULT nextval('public.gaji_petani_id_gaji_seq'::regclass);
 B   ALTER TABLE public.gaji_petani ALTER COLUMN id_gaji DROP DEFAULT;
       public          postgres    false    226    225    226            l           2604    20438    pencatatan id_pencatatan    DEFAULT     �   ALTER TABLE ONLY public.pencatatan ALTER COLUMN id_pencatatan SET DEFAULT nextval('public.pencatatan_id_pencatatan_seq'::regclass);
 G   ALTER TABLE public.pencatatan ALTER COLUMN id_pencatatan DROP DEFAULT;
       public          postgres    false    221    222    222            i           2604    20412    role id_role    DEFAULT     l   ALTER TABLE ONLY public.role ALTER COLUMN id_role SET DEFAULT nextval('public.role_id_role_seq'::regclass);
 ;   ALTER TABLE public.role ALTER COLUMN id_role DROP DEFAULT;
       public          postgres    false    216    215    216                      0    20416    akun 
   TABLE DATA           X   COPY public.akun (id_akun, username, nomor_telepon, role_id_role, password) FROM stdin;
    public          postgres    false    218   Y;                 0    20428    bahan 
   TABLE DATA           A   COPY public.bahan (id_bahan, nama_bahan, keterangan) FROM stdin;
    public          postgres    false    220   �;                 0    20447    detail_pencatatan 
   TABLE DATA           v   COPY public.detail_pencatatan (id_detail, quantity, keterangan, pencatatan_id_pencatatan, bahan_id_bahan) FROM stdin;
    public          postgres    false    224   �<                 0    20464    gaji_petani 
   TABLE DATA           Z   COPY public.gaji_petani (id_gaji, tanggal, nominal, keterangan, akun_id_akun) FROM stdin;
    public          postgres    false    226    =                 0    20435 
   pencatatan 
   TABLE DATA           J   COPY public.pencatatan (id_pencatatan, tanggal, akun_id_akun) FROM stdin;
    public          postgres    false    222   @=                 0    20409    role 
   TABLE DATA           2   COPY public.role (id_role, nama_role) FROM stdin;
    public          postgres    false    216   �=       '           0    0    akun_id_akun_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('public.akun_id_akun_seq', 3, true);
          public          postgres    false    217            (           0    0    bahan_id_bahan_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.bahan_id_bahan_seq', 7, true);
          public          postgres    false    219            )           0    0    detail_pencatatan_id_detail_seq    SEQUENCE SET     M   SELECT pg_catalog.setval('public.detail_pencatatan_id_detail_seq', 6, true);
          public          postgres    false    223            *           0    0    gaji_petani_id_gaji_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public.gaji_petani_id_gaji_seq', 4, true);
          public          postgres    false    225            +           0    0    pencatatan_id_pencatatan_seq    SEQUENCE SET     J   SELECT pg_catalog.setval('public.pencatatan_id_pencatatan_seq', 4, true);
          public          postgres    false    221            ,           0    0    role_id_role_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('public.role_id_role_seq', 2, true);
          public          postgres    false    215            r           2606    20421    akun akun_pkey 
   CONSTRAINT     Q   ALTER TABLE ONLY public.akun
    ADD CONSTRAINT akun_pkey PRIMARY KEY (id_akun);
 8   ALTER TABLE ONLY public.akun DROP CONSTRAINT akun_pkey;
       public            postgres    false    218            t           2606    20433    bahan bahan_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.bahan
    ADD CONSTRAINT bahan_pkey PRIMARY KEY (id_bahan);
 :   ALTER TABLE ONLY public.bahan DROP CONSTRAINT bahan_pkey;
       public            postgres    false    220            x           2606    20452 (   detail_pencatatan detail_pencatatan_pkey 
   CONSTRAINT     m   ALTER TABLE ONLY public.detail_pencatatan
    ADD CONSTRAINT detail_pencatatan_pkey PRIMARY KEY (id_detail);
 R   ALTER TABLE ONLY public.detail_pencatatan DROP CONSTRAINT detail_pencatatan_pkey;
       public            postgres    false    224            z           2606    20471    gaji_petani gaji_petani_pkey 
   CONSTRAINT     _   ALTER TABLE ONLY public.gaji_petani
    ADD CONSTRAINT gaji_petani_pkey PRIMARY KEY (id_gaji);
 F   ALTER TABLE ONLY public.gaji_petani DROP CONSTRAINT gaji_petani_pkey;
       public            postgres    false    226            v           2606    20440    pencatatan pencatatan_pkey 
   CONSTRAINT     c   ALTER TABLE ONLY public.pencatatan
    ADD CONSTRAINT pencatatan_pkey PRIMARY KEY (id_pencatatan);
 D   ALTER TABLE ONLY public.pencatatan DROP CONSTRAINT pencatatan_pkey;
       public            postgres    false    222            p           2606    20414    role role_pkey 
   CONSTRAINT     Q   ALTER TABLE ONLY public.role
    ADD CONSTRAINT role_pkey PRIMARY KEY (id_role);
 8   ALTER TABLE ONLY public.role DROP CONSTRAINT role_pkey;
       public            postgres    false    216            {           2606    20422    akun akun_role_id_role_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.akun
    ADD CONSTRAINT akun_role_id_role_fkey FOREIGN KEY (role_id_role) REFERENCES public.role(id_role);
 E   ALTER TABLE ONLY public.akun DROP CONSTRAINT akun_role_id_role_fkey;
       public          postgres    false    216    218    4720            }           2606    20458 7   detail_pencatatan detail_pencatatan_bahan_id_bahan_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.detail_pencatatan
    ADD CONSTRAINT detail_pencatatan_bahan_id_bahan_fkey FOREIGN KEY (bahan_id_bahan) REFERENCES public.bahan(id_bahan);
 a   ALTER TABLE ONLY public.detail_pencatatan DROP CONSTRAINT detail_pencatatan_bahan_id_bahan_fkey;
       public          postgres    false    224    4724    220            ~           2606    20453 A   detail_pencatatan detail_pencatatan_pencatatan_id_pencatatan_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.detail_pencatatan
    ADD CONSTRAINT detail_pencatatan_pencatatan_id_pencatatan_fkey FOREIGN KEY (pencatatan_id_pencatatan) REFERENCES public.pencatatan(id_pencatatan);
 k   ALTER TABLE ONLY public.detail_pencatatan DROP CONSTRAINT detail_pencatatan_pencatatan_id_pencatatan_fkey;
       public          postgres    false    4726    222    224                       2606    20472 )   gaji_petani gaji_petani_akun_id_akun_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.gaji_petani
    ADD CONSTRAINT gaji_petani_akun_id_akun_fkey FOREIGN KEY (akun_id_akun) REFERENCES public.akun(id_akun);
 S   ALTER TABLE ONLY public.gaji_petani DROP CONSTRAINT gaji_petani_akun_id_akun_fkey;
       public          postgres    false    218    4722    226            |           2606    20441 '   pencatatan pencatatan_akun_id_akun_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.pencatatan
    ADD CONSTRAINT pencatatan_akun_id_akun_fkey FOREIGN KEY (akun_id_akun) REFERENCES public.akun(id_akun);
 Q   ALTER TABLE ONLY public.pencatatan DROP CONSTRAINT pencatatan_akun_id_akun_fkey;
       public          postgres    false    222    218    4722               >   x�3���L,*J�4�0426153��4�4�r��83SR��R��f�&�F��F`�=... �{`         �   x�]��JA�ϳO������-E)BAO�%۝Ά��,3��ۛ��oI�?�%�Fx����<��X;�,:��#C�� ~l1�67x9���Z_R��T�R��9,亦���={&%Z0*$X sq6�Zx���~`&?ǕC�a�ߺ���P��'1w?/
�Q�N�O�Ʒ>�1�;k랸�(?�N3�s�o�sg~�h�����:a�G��q��4��d��d�
e����}}�/�~�4��/��         K   x�3�44�,�+)�V(H�--(�N��4�4�2�.a�e�,������0�4�2�42��4�ˌ��C�	PG� �5%         0   x�3�4202�50�50�445 N�ĬL��Ҝ�<��LNC�=... �I	a         0   x�3�4202�50�50�4�2Bp�L.c8�� (k���ec���� ]�
[            x�3��/�K-�2�,H-I������� J��     