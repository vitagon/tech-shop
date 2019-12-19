import React, { Component } from "react";
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faArrowRight, faArrowLeft } from '@fortawesome/free-solid-svg-icons';
import styles from './SliderArrows.module.css';

class SliderArrows extends Component {
  
  render() {
    return (
      <div id="slick-nav-1" className={styles['products-slick-nav']} style={{ bottom: this.props.bottom }}>
        <button className={styles['slick-prev']} onClick={this.props.previous}>
          <FontAwesomeIcon icon={faArrowLeft} />
        </button>
        <button className={styles['slick-next']} onClick={this.props.next}>
          <FontAwesomeIcon icon={faArrowRight} />
        </button>
      </div>
    )
  }
};

export default SliderArrows;