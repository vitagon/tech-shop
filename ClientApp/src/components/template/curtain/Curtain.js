import React, { Component } from 'react';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import { HIDE_SIDE_NAV_PANEL } from '../../../reducers/navPanelReducer';
import './Curtain.css';


class Curtain extends Component {
  render() {
    return this.props.showSideNavPanel ?
            (<div id="curtain" onClick={this.props.hideSideNavPanel}></div>) : null;
  }
}

const mapStateToProps = (state) => ({
  showSideNavPanel: state.navPanelReducer.showSideNavPanel
});

const mapDispatchToProps = (dispatch) => bindActionCreators({
  hideSideNavPanel: () => (dispatch) => dispatch({ type: HIDE_SIDE_NAV_PANEL, payload: false })
}, dispatch);

export default connect(mapStateToProps, mapDispatchToProps)(Curtain);