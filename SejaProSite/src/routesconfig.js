import Agenda from "./pages/agenda/Agenda";
import Contato from "./pages/contato/Contato";
import Home from "./pages/home/Home";
import Ministerio from "./pages/ministerio/Ministerio";
import Projeto from "./pages/projeto/Projeto";

const routesConfig = [
  {
    path: "/",
    component: Home,
    exact: true,
  },
  {
    path: "/ministerios",
    component: Ministerio,
    exact: true,
  },
  {
    path: "/projetos",
    component: Projeto,
    exact: true,
  },
  {
    path: "/agenda",
    component: Agenda,
    exact: true,
  },
  {
    path: "/contatos",
    component: Contato,
    exact: true,
  },
];

export default routesConfig