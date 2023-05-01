body {
  margin: 0;
  padding: 0;
}

.heder-main-menu {
  display: flex;
  justify-content: space-around;
  position: absolute;
  z-index: 9;
  width: 99%;
  margin-top: 20px;
}
.heder-main-menu .header-logo h2 {
  height: 45px;
  color: aliceblue;
  font-size: 18px;
  font-weight: 800;
  font-family: "Montserrat", sans-serif;
  letter-spacing: 1;
  height: 20px;
}
.heder-main-menu .header-text-div .header-ul {
  width: 557px;
  display: flex;
  list-style-type: none;
  justify-content: space-between;
  margin-top: 0px;
}
.heder-main-menu .header-text-div .header-ul .header-li {
  line-height: 4;
}
.heder-main-menu .header-text-div .header-ul .header-li .header-link {
  text-decoration: none;
  color: aliceblue;
  font-family: "Poppins", sans-serif;
  font-size: 14px;
  font-weight: 400;
  line-height: 20px;
}

.bener-img {
  background-image: url(../img/bg.jpg);
  background-position: center center;
  background-repeat: no-repeat;
  background-size: cover;
  width: 100%;
  height: 100vh;
  top: 0;
  position: relative;
}
.bener-img .bener-color {
  background-color: rgba(0, 0, 0, 0.64);
  width: 100%;
  height: 100vh;
  display: flex;
  justify-content: center;
  flex-direction: column;
}
.bener-img h1 {
  margin-top: 0px;
  font-size: 47px;
  color: #fff;
  font-weight: 800;
  font-family: "Montserrat", sans-serif;
  margin-bottom: 0px;
  text-align: center;
}
.bener-img .bener-img .cd-headline {
  font-size: 3rem;
  line-height: 1.2;
  margin-top: 0px;
}
.bener-img .cd-words-wrapper {
  display: inline-block;
  position: relative;
  text-align: left;
}
.bener-img .cd-words-wrapper b {
  display: inline-block;
  position: absolute;
  white-space: nowrap;
  left: 0;
  top: 0;
}
.bener-img .cd-intro {
  text-align: center;
  font-size: 40px;
}
.bener-img .cd-intro h1 {
  margin-top: 0px;
  font-family: "Montserrat", sans-serif;
  font-size: 60px;
  font-weight: 400;
  color: white;
}
.bener-img .cd-words-wrapper b.is-visible {
  position: relative;
}
.bener-img .no-js .cd-words-wrapper b {
  opacity: 0;
}
.bener-img .no-js .cd-words-wrapper b.is-visible {
  opacity: 1;
}
.bener-img .cd-headline.clip span {
  display: inline-block;
  padding: 0.2em 0;
}
.bener-img .cd-headline.clip .cd-words-wrapper {
  overflow: hidden;
  vertical-align: top;
}
.bener-img .cd-headline.clip .cd-words-wrapper::after {
  /* line */
  content: "";
  position: absolute;
  top: 0;
  right: 0;
  width: 2px;
  height: 100%;
  background-color: #5c4f4f;
}
.bener-img .cd-headline.clip b {
  opacity: 0;
}
.bener-img .cd-headline.clip b.is-visible {
  opacity: 1;
}

.about-main {
  display: flex;
}
.about-main .about {
  width: 1440px;
  margin: 0 auto;
}
.about-main .about-image {
  width: 50%;
}

/*# sourceMappingURL=output.cs.map */
