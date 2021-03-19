import React, { Component } from "react";

import img1 from "../../images/about-img-1.jpg";
import img2 from "../../images/about-img-2.jpg";
import palavra from "../../images/icones/biblia.png";
import oracao from "../../images/icones/oracao.png";
import espiritoSanto from "../../images/icones/espiritoSanto.jpg";
import donsMinisterio from "../../images/icones/donsMinisterios.jpg";
import familia from "../../images/icones/familia.jpg";
import lideranca from "../../images/icones/lideranca.jpg";

class Home extends Component {
  render() {
    return (
      <div className="Container">
        <div className="row">
          <div className="container">
            <div className="row">
              <div className="col-md-6">
                <div className="heading-left">
                  <h2>Sobre a igreja</h2>
                </div>
                <strong className="title">
                  Igreja Batista Provisão, Restaurando a visão da família de Deus!
                </strong>
                <p align="justify">
                  Quanto mais nos aproximamos de Deus, mais claramente nos
                  enxergamos como realmente somos. Devemos estar sensíveis a
                  obra que o Senhor quer operar em nossas vidas através da
                  restauração da nossa visão. Todos nós necessitamos que o
                  Espírito santo nos conduza a sua verdade. Iremos experimentar
                  o AVIVAMENTO na medida em que nos dispomos nas mãos do Pai e
                  permitimos que ele nos esvazie das nossa convicção, vontade,
                  orgulho, vaidade, egoísmo, frieza, individualidade e
                  religiosidade e assim nos encha da Sua própria VIDA.
                </p>
                <br></br>
                <br></br>
                <br></br>
                <br></br>
              </div>
              <div className="col-md-6">
                <div className="frame-1">
                  <img src={img1} alt="img" className="imgHome jumbotron" />
                </div>
                <div className="frame-2">
                  <img src={img2} alt="img" className="imgHome jumbotron" />
                </div>
              </div>
            </div>
          </div>
        </div>

        <div className="row">
          <div className="container">
            <div className="heading-center">
              <h2>Princípios Norteadores</h2>
            </div>
            <div className="row">
              <div className="col-md-4 col-sm-4">
                <div className="jumbotron textBox">
                  <img src={palavra} alt="Palavra" className="icone" />
                  <h5>Palavra</h5>
                  <p>
                    Igreja baseada no poder ilimitado da Palavra de Deus. A
                    Bíblia é o ponto de partida e de chegada para todo
                    ministério da igreja. A Bíblia é a visão maior, a lente mais
                    ampla, o instrumento mais potente, através do qual a igreja
                    tem que viver. Igreja que vive da força da sua pregação. A
                    pregação para a transformação de vidas deve ocupar o lugar
                    central. Uma pregação ungida, criativa, sólida e
                    contextualizada deve ser um dos carros-chefes do ministério
                    da igreja.
                  </p>
                </div>
              </div>
              <div className="col-md-4 col-sm-4">
                <div className="jumbotron textBox">
                  <img src={oracao} alt="Oração" className="icone" />
                  <h5>Oração</h5>
                  <p>
                    Igreja que entende a oração como a fonte de um poder
                    ilimitado para transformar a si mesma, e capacitar para
                    realizar aquilo para o que Deus, nos tem chamado a fazer.
                    Igreja que tem a oração, como sendo a força mais essencial
                    ao seu ministério. Nada será tão eficiente sem a força da
                    oração, e tudo será suficiente quando alimentado por ela.
                    Não há a menor possibilidade de ser e existir como igreja,
                    sem um sério investimento na oração.
                  </p>
                </div>
              </div>
              <div className="col-md-4 col-sm-4">
                <div className="jumbotron textBox">
                  <img
                    src={espiritoSanto}
                    alt="Espirito Santo"
                    className="icone"
                  />
                  <h5>Espírito Santo</h5>
                  <p>
                    Igreja aberta à atuação do Espírito Santo, que entende a
                    capacitação dada por Deus no pentecostes para sair a partir
                    de Jerusalém e fazer discípulos de todas as nações. Igreja
                    capacitada pelo Espírito Santo e que busca andar em
                    obediência à sua direção, a semelhança do que aconteceu em
                    Antioquia, em Atos 13:1-3.
                  </p>
                </div>
              </div>
            </div>
            <div className="row">
              <div className="col-md-4 col-sm-4">
                <div className="jumbotron textBox">
                  <img
                    src={donsMinisterio}
                    alt="Dons e Ministérios"
                    className="icone"
                  />
                  <h5>Dons e Ministérios</h5>
                  <p>
                    Todo cristão tem um, ou mais dons espirituais, concedidos
                    pelo Espírito Santo de Deus (1 Cor 12). Baseado nesta
                    verdade básica, cada cristão descobre seu dom espiritual e o
                    desenvolve entendendo por ministério o espaço, no qual
                    pessoas de um mesmo dom se encontram para desenvolver o seu
                    chamado específico. Quantos forem os dons descobertos no
                    seio da comunidade, tantos serão os ministérios existentes
                    nela.
                  </p>
                </div>
              </div>
              <div className="col-md-4 col-sm-4">
                <div className="jumbotron textBox">
                  <img
                    src={familia}
                    alt="Dons e Ministérios"
                    className="icone"
                  />
                  <h5>Família</h5>
                  <p>
                    Um dos seus principais focos de ação precisa ser a família e
                    seus membros. Através dos grupos pequenos, seminários,
                    encontros de casais, retiros, acampamentos etc., pode-se
                    alcançar e trabalhar os componentes da família, na busca de
                    fazê-los mais saudáveis: física, emocional e
                    espiritualmente.
                  </p>
                </div>
              </div>
              <div className="col-md-4 col-sm-4">
                <div className="jumbotron textBox">
                  <img
                    src={lideranca}
                    alt="Dons e Ministérios"
                    className="icone"
                  />
                  <h5>Liderança</h5>
                  <p>
                    Estilo de liderança, que tem no Pastor, um mentor e
                    incentivador dos ministérios. Uma liderança pastoral, que
                    abre espaço através da mentoria para o florescimento das
                    lideranças leigas na igreja. Juntamente com o pastor,
                    aprendem a pastorear o povo de Deus à semelhança daquilo,
                    que aconteceu com Moisés depois de ter recebido o conselho
                    ministerial de Jetro no deserto (conferir Êxodo 18: 13-27).
                  </p>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    );
  }
}

export default Home;
