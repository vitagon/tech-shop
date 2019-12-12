import React from "react";
import Section1 from './section1/Section1';
import Section2 from './section2/Section2';
import HotDeal from './hotDeal/HotDeal';
import Section3 from './section3/Section3';
import Section4 from './section4/Section4';

const Home = () => {
  return (
    <div>
      <Section1></Section1>
      <Section2></Section2>
      <HotDeal></HotDeal>
      <Section3></Section3>
      <Section4></Section4>
    </div>
  );
};

export default Home;