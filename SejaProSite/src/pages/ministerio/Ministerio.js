import React, { Component } from "react";

import infanto from "../../images/ministerios/ministerioInfantoJuvenil.jpg";
import louvor from "../../images/ministerios/LouvoreAdoracao.jpg";
import adolescente from "../../images/ministerios/adolescentes.jpg";
import epa from "../../images/ministerios/epa.jpg";

class Ministerio extends Component {
  render() {
    return (
      <div className="container">
        <div className="row">
          <div className="container">
            <div className="heading-center">
              <h2>Nossos Ministérios</h2>
            </div>
            <div className="row">
              <div className="col-md-6 col-sm-6">
                <div className="jumbotron textebox textBoxMedia">
                  <img
                    src={infanto}
                    alt="Ministério Infantojuvenil"
                    className="iconeMedia"
                  />
                  <h5>Ministério Infantojuvenil</h5>
                  <p>
                    O ministério infantojuvenil da IBP acredita na relevância de
                    semear as verdades do evangelho no coração da próxima
                    geração. Para nós, as crianças são a igreja de hoje. Dessa
                    forma, precisam ser orientadas, amadas e desenvolver suas
                    próprias experiências com Deus.
                  </p>
                  <p>
                    Nosso objetivo é sermos facilitadores nesse processo,
                    ministrando um ensino bíblico sistematizado, consistente,
                    relevante e em linguagem adequada às crianças,
                    estimulando-as a serem discípulos de Jesus.
                  </p>
                  <p className="textFooter">Lideres: Vanessa Barbosa</p>
                </div>
              </div>
              <div className="col-md-6 col-sm-6">
                <div className="jumbotron textebox textBoxMedia">
                  <img
                    src={louvor}
                    alt="Louvor e Adoração"
                    className="iconeMedia"
                  />
                  <h5>Louvor e Adoração</h5>
                  <p>
                    O Ministério de Louvor da IBP é formado por um grupo de
                    músicos e ministros comprometidos em cumprir, em unidade, um
                    propósito: ADORAÇÃO AO SENHOR EM ESPÍRITO E VERDADE. Para
                    tal, não priorizamos os talentos, mas a fidelidade e o
                    compromisso de cada participante. Entendemos que a nossa
                    missão será cumprida de fato, quando entendermos que para
                    alcançar o propósito precisamos nos esvaziar de nós mesmos e
                    nos render à vontade de Deus, assim como Jesus nos ensinou:
                    “Tenham a mesma atitude demonstrada por Cristo Jesus. Embora
                    sendo Deus, não considerou que ser igual a Deus fosse algo a
                    que devesse se apegar.” (Filipenses‬ ‭2:5-6‬ ‭NVT‬‬).
                  </p>
                  <p>
                    Cremos que fomos chamados por Deus para vivermos o
                    sobrenatural e proclamarmos a mensagem viva que transmite
                    vida às pessoas e que a verdadeira unidade é constituída por
                    Deus e não por homens.
                  </p>
                  <p className="textFooter">
                    Lideres: Priscila Amorim e Renata Fernandes
                  </p>
                </div>
              </div>
            </div>
            <div className="row">
              <div className="col-md-6 col-sm-6">
                <div className="jumbotron textebox textBoxMedia">
                  <img
                    src={adolescente}
                    alt="Ministério de Adolescentes"
                    className="iconeMedia"
                  />
                  <h5>Ministério de Adolescentes</h5>
                  <p>
                    Sabemos que ser um adolescente nos dias atuais não é fácil!
                    Existem muitas dúvidas sobre o futuro a seguir, pressão de
                    todos os lados e o desejo de se encontrar e se encaixar
                    nesse mundo... Por conta disso, nós, do Ministério de
                    adolescentes IBP, gostamos de estar sempre presentes e
                    dispostos a ouvir, bater um papo e SEMPRE buscar respostas
                    com o PAI mais amoroso que existe, o nosso Deus!
                  </p>
                  <p>
                    Nosso objetivo é estar de braços abertos para os novos
                    desafios e para aqueles que precisarem!
                  </p>
                  <p className="textFooter">
                    Lideres: Rebeca e Vinicius / Elisangela e Osvaldino
                  </p>
                </div>
              </div>
              <div className="col-md-6 col-sm-6">
                <div className="jumbotron textebox textBoxMedia">
                  <img
                    src={epa}
                    alt="Ministério de Jovens"
                    className="iconeMedia"
                  />
                  <h5>Ministério de Jovens</h5>
                  <p>
                    Somos o EPA (Escolhidos Para Adorar), o ministério de jovens
                    da IBP. Temos como objetivo no nosso ministério amar,
                    cuidar, orientar e fazer com que esse mesmo amor que
                    sentimos e vivemos de Deus por nós seja espalhado para
                    outros.
                  </p>
                  <p>Você que é jovem, o EPA te recebe de braços abertos.</p>
                  <p className="textFooter">
                    Lideres: Carina Alencar e Willian Alencar
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

export default Ministerio;
