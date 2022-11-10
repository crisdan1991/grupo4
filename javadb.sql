--
-- PostgreSQL database dump
--

-- Dumped from database version 14.5
-- Dumped by pg_dump version 14.5

-- Started on 2022-11-10 01:01:16

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_table_access_method = heap;

--
-- TOC entry 210 (class 1259 OID 16951)
-- Name: cuenta; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.cuenta (
    id integer NOT NULL,
    numerocuenta character varying NOT NULL,
    saldo double precision,
    operacion character varying
);


ALTER TABLE public.cuenta OWNER TO postgres;

--
-- TOC entry 209 (class 1259 OID 16950)
-- Name: cuenta_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.cuenta_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.cuenta_id_seq OWNER TO postgres;

--
-- TOC entry 3311 (class 0 OID 0)
-- Dependencies: 209
-- Name: cuenta_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.cuenta_id_seq OWNED BY public.cuenta.id;


--
-- TOC entry 3164 (class 2604 OID 16970)
-- Name: cuenta id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.cuenta ALTER COLUMN id SET DEFAULT nextval('public.cuenta_id_seq'::regclass);


--
-- TOC entry 3305 (class 0 OID 16951)
-- Dependencies: 210
-- Data for Name: cuenta; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.cuenta (id, numerocuenta, saldo, operacion) FROM stdin;
7	1722207709	100	\N
8	1722207709	2000	\N
9	1722207709	1990	-10.0
10	1722207709	2000	+10.0
11	1722207709	2100	+100.0
\.


--
-- TOC entry 3312 (class 0 OID 0)
-- Dependencies: 209
-- Name: cuenta_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.cuenta_id_seq', 11, true);


-- Completed on 2022-11-10 01:01:16

--
-- PostgreSQL database dump complete
--

